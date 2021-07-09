using Newtonsoft.Json;
using PochtaAPI.Interfaces;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PochtaAPI
{
    internal class BaseClient : IDisposable
    {
        protected HttpClient Client;
        protected JsonSerializer Serializer;
        private const string URL = "https://otpravka-api.pochta.ru";
        private const string V1 = "1.0";

        static BaseClient()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }

        public BaseClient(string Token, string Login, string Password) : this(Token, Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Login}:{Password}"))) { }

        public BaseClient(string Token, string Key)
        {
            Serializer = new JsonSerializer();
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("Content-Type", "application/json;charset=UTF-8");
            Client.DefaultRequestHeaders.Add("Authorization", "AccessToken " + Token);
            Client.DefaultRequestHeaders.Add("X-User-Authorization", "Basic " + Key);
        }

        public void Dispose()
        {
            Client.Dispose();
        }

        protected Task<T> CallAPI<T>(string Resource) => CallAPI<T>(Resource, null);

        protected async Task<T> CallAPI<T>(string Resource, IRequestParameter RP)
        {
            using (var HRM = new HttpRequestMessage(HttpMethod.Get, Resource))
            using (var httpResponse = await Client.SendAsync(HRM))
            {
                httpResponse.EnsureSuccessStatusCode();
                return await Deserialize<T>(httpResponse);
            }
        }

        protected async Task<T> CallAPI<T>(HttpMethod Method, string Resource, object Data, IRequestParameter RP)
        {
            using (var HRM = new HttpRequestMessage(Method, Resource))
            using (var httpContent = Serialize(Data))
            {
                HRM.Content = httpContent;
                using (var httpResponse = await Client.SendAsync(HRM))
                {
                    httpResponse.EnsureSuccessStatusCode();
                    return await Deserialize<T>(httpResponse);
                }
            }
        }

        protected async Task CallAPIDownload(string Resource, string Target)
        {
            var URL = BuildURL(Resource, null);
            using (var HR = await Client.GetAsync(URL))
            {
                var S = await HR.Content.ReadAsStreamAsync();
                using (var FS = File.OpenWrite(Target))
                {
                    await S.CopyToAsync(FS);
                }
            }
        }

        private string BuildURL(string Resource, IRequestParameter RP)
        {
            return $"{URL}/{V1}/{Resource}";
        }

        private async Task<T> Deserialize<T>(HttpResponseMessage HRM)
        {
            var S = await HRM.Content.ReadAsStreamAsync();
            using (var SR = new StreamReader(S))
            {
                string responseText = SR.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(responseText);
            }
        }

        private HttpContent Serialize(object request)
        {
            MemoryStream MS = new MemoryStream();
            using (var SW = new StreamWriter(MS, new UTF8Encoding(false), 1024, true))
            using (var JTW = new JsonTextWriter(SW))
            {
                Serializer.Serialize(JTW, request);
                JTW.Flush();
            }
            MS.Seek(0, SeekOrigin.Begin);
            var httpContent = new StreamContent(MS);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return httpContent;
        }
    }
}