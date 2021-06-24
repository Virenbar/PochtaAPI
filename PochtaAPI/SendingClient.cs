using RestSharp;
using System;
using System.Text;
using System.Threading.Tasks;

namespace PochtaAPI
{
    /// <summary>
    /// Клиент для работы с API отправки
    /// </summary>
    public class SendingClient
    {
        private readonly IRestClient Client;
        private const string URL = "https://otpravka-api.pochta.ru/1.0";

        /// <summary>
        ///
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        public SendingClient(string Token, string Login, string Password) : this("", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Login}:{Password}"))) { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="Key"></param>
        public SendingClient(string Token, string Key)
        {
            Client = new RestClient(URL);
            Client.AddDefaultHeader("Content-Type", "application/json;charset=UTF-8");
            Client.AddDefaultHeader("Authorization", "AccessToken " + Token);
            Client.AddDefaultHeader("X-User-Authorization", "Basic " + Key);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<string> GetOrderAsync(int ID)
        {
            IRestRequest Request = new RestRequest($"backlog/{ID}", Method.GET);
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public async Task<string> GetOrderAsync(string ID)
        {
            IRestRequest Request = new RestRequest("backlog/search", Method.GET);
            Request.AddQueryParameter("query", "");
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetBatchAsync()
        {
            IRestRequest Request = new RestRequest("batch", Method.GET);
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<string> GetBatchAsync(string Name)
        {
            IRestRequest Request = new RestRequest($"batch/{Name}", Method.GET);
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<string> GetBatchOrdersAsync(string Name)
        {
            IRestRequest Request = new RestRequest($"batch/{Name}/shipment", Method.GET);
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }
    }
}