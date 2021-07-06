using PochtaAPI.SData;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PochtaAPI
{
    /// <summary>
    /// Клиент для работы с API отправки
    /// </summary>
    public class SendingClient
    {
        private const string URL = "https://otpravka-api.pochta.ru/1.0";
        private readonly IRestClient Client;

        /// <summary>
        ///
        /// </summary>
        /// <param name="Token"></param>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        public SendingClient(string Token, string Login, string Password) : this(Token, Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Login}:{Password}"))) { }

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

        private Task<IRestResponse> CallAPI(string Resource) { return CallAPI(Method.GET, Resource, null); }

        private Task<IRestResponse> CallAPI(Method Method, string Resource) { return CallAPI(Method, Resource, null); }

        private Task<IRestResponse<T>> CallAPI<T>(string Resource) { return CallAPI<T>(Method.GET, Resource, null); }

        private Task<IRestResponse<T>> CallAPI<T>(Method Method, string Resource) { return CallAPI<T>(Method, Resource, null); }

        private async Task<IRestResponse> CallAPI(Method Method, string Resource, object Body)
        {
            IRestResponse R = null;
            switch (Method)
            {
                case Method.GET:
                    {
                        IRestRequest Request = new RestRequest(Resource, Method.GET);
                        R = await Client.ExecuteGetAsync(Request);
                        break;
                    }
                case Method.POST:
                case Method.PUT:
                case Method.DELETE:
                    {
                        IRestRequest Request = new RestRequest(Resource, Method.POST);
                        Request.AddParameter("application/json", Body, ParameterType.RequestBody);
                        R = await Client.ExecutePostAsync(Request);
                        break;
                    }
                default: break;
            }
            return R;
        }

        private async Task<IRestResponse<T>> CallAPI<T>(Method Method, string Resource, object Body)
        {
            IRestResponse<T> R = null;
            switch (Method)
            {
                case Method.GET:
                    {
                        IRestRequest Request = new RestRequest(Resource, Method);
                        R = await Client.ExecuteGetAsync<T>(Request);
                        break;
                    }
                case Method.POST:
                case Method.PUT:
                case Method.DELETE:
                    {
                        IRestRequest Request = new RestRequest(Resource, Method);
                        Request.AddParameter("application/json", Body, ParameterType.RequestBody);
                        R = await Client.ExecutePostAsync<T>(Request);
                        break;
                    }
                default: break;
            }
            return R;
        }

        #region Заказы

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

        #endregion Заказы

        #region Партии

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

        #endregion Партии

        #region Документы
        //TODO
        #endregion Документы

        #region Архив
        //TODO
        #endregion Архив

        #region Данные

        /// <summary>
        /// Нормализация адреса
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public async Task<List<Address>> CleanAddress(IEnumerable<Address> List)
        {
            var Body = "[" + string.Join(",", List.Select(A => A.AsJSON())) + "]";
            var R = await CallAPI<List<Address>>(Method.POST, "", Body);
            //IRestRequest Request = new RestRequest($"clean/address", Method.POST);
            //Request.AddParameter("application/json", Body, ParameterType.RequestBody);
            //var R = await Client.ExecutePostAsync<List<Address>>(Request);
            return R.Data;
        }

        /// <summary>
        /// Текущее количество запросов по API
        /// </summary>
        /// <returns></returns>
        public async Task<APILimit> GetAPILimit()
        {
            var R = await CallAPI<APILimit>("settings/limit");
            //IRestRequest Request = new RestRequest("settings/limit", Method.GET);
            //var R = await Client.ExecuteGetAsync<APILimit>(Request);
            return R.Data;
        }

        /// <summary>
        /// Нормализация ФИО
        /// </summary>
        /// <returns></returns>
        private async Task<string> CleanFIO()
        {
            IRestRequest Request = new RestRequest("clean/physical", Method.POST);
            var R = await Client.ExecutePostAsync(Request);
            return R.Content;
        }

        /// <summary>
        /// Нормализация телефона
        /// </summary>
        /// <returns></returns>
        private async Task<string> CleanPhone()
        {
            IRestRequest Request = new RestRequest("clean/phone", Method.POST);
            var R = await Client.ExecutePostAsync(Request);
            return R.Content;
        }

        /// <summary>
        /// Расчет стоимости пересылки
        /// </summary>
        /// <returns></returns>
        private async Task<string> Tariff()
        {
            IRestRequest Request = new RestRequest("tariff", Method.POST);
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }

        #endregion Данные

        private async Task<string> Prototype()
        {
            IRestRequest Request = new RestRequest($"", Method.GET);
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }
    }
}