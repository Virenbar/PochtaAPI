using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PochtaAPI
{
    public class BaseClient : IDisposable
    {
        protected HttpClient Client;
        protected JsonSerializer Serializer;
        private const string EndPoint = "https://otpravka-api.pochta.ru";
        private const string V1 = "1.0";

        static BaseClient()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }

        protected BaseClient(string Token, string Login, string Password) : this(Token, Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Login}:{Password}"))) { }

        protected BaseClient(string Token, string Key)
        {
            Serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            };
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Add("Authorization", "AccessToken " + Token);
            Client.DefaultRequestHeaders.Add("X-User-Authorization", "Basic " + Key);
        }

        /// <summary/>
        public void Dispose()
        {
            Client.Dispose();
        }

        protected Task<T> CallAPI<T>(string Resource, object Data) => CallAPI<T>(Resource, Data, HttpMethod.Post, null);

        protected Task<T> CallAPI<T>(string Resource, object Data, Parameters P) => CallAPI<T>(Resource, Data, HttpMethod.Post, P);

        protected Task<T> CallAPI<T>(string Resource, object Data, HttpMethod Method) => CallAPI<T>(Resource, Data, Method, null);

        protected async Task<T> CallAPI<T>(string Resource, object Data, HttpMethod Method, Parameters P)
        {
            var URL = BuildURL(Resource, P);
            using (var Request = new HttpRequestMessage(Method, URL))
            using (var SC = Serialize(Data))
            {
                Request.Content = SC;
                using (var Responce = await Client.SendAsync(Request).ConfigureAwait(false))
                {
                    Responce.EnsureSuccessStatusCode();
                    return await Deserialize<T>(Responce).ConfigureAwait(false);
                }
            }
        }

        protected async Task CallAPIDownload(string Resource, string Target)
        {
            var URL = BuildURL(Resource, null);
            using (var HR = await Client.GetAsync(URL).ConfigureAwait(false))
            {
                var S = await HR.Content.ReadAsStreamAsync().ConfigureAwait(false);
                using (var FS = File.OpenWrite(Target))
                {
                    await S.CopyToAsync(FS).ConfigureAwait(false);
                }
            }
        }

        protected Task<T> CallAPIGet<T>(string Resource) => CallAPIGet<T>(Resource, null);

        protected async Task<T> CallAPIGet<T>(string Resource, Parameters P)
        {
            var URL = BuildURL(Resource, P);
            using (var Request = new HttpRequestMessage(HttpMethod.Get, URL))
            using (var Responce = await Client.SendAsync(Request).ConfigureAwait(false))
            {
                Responce.EnsureSuccessStatusCode();
                return await Deserialize<T>(Responce).ConfigureAwait(false);
            }
        }

        private string BuildURL(string Resource, Parameters Params)
        {
            var URL = $"{EndPoint}/{V1}/{Resource}";
            if (Params != null && Params.Count > 0) { URL += $"?{Params.ToQuery()}"; }
            return URL;
        }

        private async Task<T> Deserialize<T>(HttpResponseMessage HRM)
        {
            var S = await HRM.Content.ReadAsStreamAsync().ConfigureAwait(false);
            using (var SR = new StreamReader(S))
            {
                string Response = SR.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(Response);
            }
        }

        private HttpContent Serialize(object request)
        {
            MemoryStream MS = new MemoryStream();
            using (var SW = new StreamWriter(MS, new UTF8Encoding(false), 1024, true))
            using (var JTW = new JsonTextWriter(SW) { Formatting = Formatting.None })
            {
                Serializer.Serialize(JTW, request);
                JTW.Flush();
            }
            MS.Seek(0, SeekOrigin.Begin);
            var SC = new StreamContent(MS);
            SC.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return SC;
        }

        [Obsolete]
        private StringContent ToString(object content)
        {
            var json = JsonConvert.SerializeObject(content, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}