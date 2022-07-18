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
        protected string EndPoint = "https://otpravka-api.pochta.ru";
        protected JsonSerializer Serializer;

        static BaseClient()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }

        protected BaseClient()
        {
            Serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
            };
            Client = new HttpClient();
        }

        public void Dispose() => Client.Dispose();

        protected Task<T> Get<T>(string Resource) => Get<T>(Resource, null);

        protected async Task<T> Get<T>(string Resource, Parameters P)
        {
            var URL = BuildURL(Resource, P);
            using (var Request = new HttpRequestMessage(HttpMethod.Get, URL))
            using (var Responce = await Client.SendAsync(Request).ConfigureAwait(false))
            {
                Responce.EnsureSuccessStatusCode();
                return await Deserialize<T>(Responce).ConfigureAwait(false);
            }
        }

        protected Task<T> Post<T>(string Resource, object Data) => Request<T>(Resource, Data, HttpMethod.Post, null);

        protected Task<T> Post<T>(string Resource, object Data, Parameters P) => Request<T>(Resource, Data, HttpMethod.Post, P);

        protected Task<T> Request<T>(string Resource, object Data, HttpMethod Method) => Request<T>(Resource, Data, Method, null);

        protected async Task<T> Request<T>(string Resource, object Data, HttpMethod Method, Parameters P)
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

        protected async Task RequestDownload(string Resource, string Target)
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

        private string BuildURL(string Resource, Parameters Params)
        {
            var URL = $"{EndPoint}/{Resource}";
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
    }
}