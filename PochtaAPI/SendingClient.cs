using PochtaAPI.Enums;
using PochtaAPI.STypes;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
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
        private const string URL = "https://otpravka-api.pochta.ru";
        private const string V1 = "1.0";
        private readonly IRestClient Client;

        /// <summary>
        /// Создаёт клиент для работы с API отправки
        /// </summary>
        /// <param name="Token">Токен</param>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        public SendingClient(string Token, string Login, string Password) : this(Token, Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Login}:{Password}"))) { }

        /// <summary>
        /// Создаёт клиент для работы с API отправки
        /// </summary>
        /// <param name="Token">Токен</param>
        /// <param name="Key">Ключ</param>
        public SendingClient(string Token, string Key)
        {
            Client = new RestClient($"{URL}/{V1}");
            Client.AddDefaultHeader("Content-Type", "application/json;charset=UTF-8");
            Client.AddDefaultHeader("Authorization", "AccessToken " + Token);
            Client.AddDefaultHeader("X-User-Authorization", "Basic " + Key);
        }

        #region Core

        private Task<IRestResponse> CallAPI(string Resource) { return CallAPI(Method.GET, Resource, null); }

        private Task<IRestResponse> CallAPI(Method Method, string Resource) { return CallAPI(Method, Resource, null); }

        private Task<IRestResponse<T>> CallAPI<T>(string Resource) { return CallAPI<T>(Method.GET, Resource, null); }

        private Task<IRestResponse<T>> CallAPI<T>(Method Method, string Resource) { return CallAPI<T>(Method, Resource, null); }

        private Task<IRestResponse<T>> CallAPI<T>(string Resource, object Body) { return CallAPI<T>(Method.GET, Resource, Body); }

        private async Task<IRestResponse> CallAPI(Method Method, string Resource, object Body)
        {
            IRestResponse R = null;
            switch (Method)
            {
                case Method.GET:
                    {
                        IRestRequest Request = new RestRequest(Resource, Method.GET);
                        if (Body != null)
                        {
                            foreach (var KVPair in (Dictionary<string, string>)Body) { if (KVPair.Value != "") { Request.AddQueryParameter(KVPair.Key, KVPair.Value); } }
                        }
                        R = await Client.ExecuteGetAsync(Request);
                        break;
                    }
                case Method.POST:
                case Method.PUT:
                case Method.DELETE:
                    {
                        IRestRequest Request = new RestRequest(Resource, Method);
                        Request.AddParameter("application/json", Body, ParameterType.RequestBody);
                        R = await Client.ExecutePostAsync(Request).ConfigureAwait(false);
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
                        if (Body != null)
                        {
                            foreach (var KVPair in (Dictionary<string, string>)Body) { if (KVPair.Value != "") { Request.AddQueryParameter(KVPair.Key, KVPair.Value); } }
                        }
                        R = await Client.ExecuteGetAsync<T>(Request);
                        break;
                    }
                case Method.POST:
                case Method.PUT:
                case Method.DELETE:
                    {
                        IRestRequest Request = new RestRequest(Resource, Method);
                        Request.AddParameter("application/json", Body, ParameterType.RequestBody);
                        R = await Client.ExecutePostAsync<T>(Request).ConfigureAwait(false);
                        break;
                    }
                default: throw new InvalidOperationException("Вам здесь не рады");
            }
            return R;
        }

        private Task CallAPIDownload(string Resource, string Target)
        {
            return Task.Run(() =>
            {
                using (var writer = File.OpenWrite(Target))
                {
                    IRestRequest Request = new RestRequest(Resource, Method.GET)
                    {
                        ResponseWriter = responseStream =>
                        {
                            using (responseStream)
                            {
                                responseStream.CopyTo(writer);
                            }
                        }
                    };
                    var R = Client.DownloadData(Request);
                }
            });
        }

        #endregion Core

        #region ЗАКАЗЫ

        /// <summary>
        /// Поиск заказа по идентификатору
        /// </summary>
        /// <param name="ID">Внутренний идентификатор отправления</param>
        /// <remarks>https://otpravka.pochta.ru/specification#/orders-search_order_byid</remarks>
        public async Task<Order> GetOrderByID(int ID)
        {
            var R = await CallAPI<Order>($"backlog/{ID}");
            return R.Data;
        }

        /// <summary>
        /// Поиск заказа
        /// </summary>
        /// <param name="Query">Буквенно-цифровой идентификатор отправления</param>
        /// <remarks>https://otpravka.pochta.ru/specification#/orders-search_order</remarks>
        public async Task<List<Order>> GetOrderByID(string Query)
        {
            var D = new Dictionary<string, string> { { "query", Query } };
            var R = await CallAPI<List<Order>>("backlog/search", D);
            return R.Data;
        }

        //TODO Создание заказа
        //TODO Создание заказа(версия №2)
        //TODO Редактирование заказа
        //TODO Удаление заказа
        //TODO Возврат заказов в "Новые"
        //TODO Поиск заказов по идентификатору группы
        #endregion ЗАКАЗЫ

        #region ПАРТИИ

        /// <summary>
        /// Поиск всех партий
        /// </summary>
        /// <returns></returns>
        public async Task<List<Batch>> GetAllBatches(MailType? mailType = null, MailCategory? mailCategory = null, int? size = null, SortType sort = SortType.ASK, int? page = null)
        {
            var D = new Dictionary<string, string>
            {
                {"mailType",mailCategory.ToString()},
                {"mailCategory",mailCategory.ToString()},
                {"size",size.ToString()},
                {"sort",sort.ToQuery()},
                {"page",page.ToString()}
            };
            var R = await CallAPI<List<Batch>>("batch", D);
            return R.Data;
        }

        /// <summary>
        /// Поиск партии по наименованию
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public async Task<Batch> GetBatchByName(string Name)
        {
            var R = await CallAPI<Batch>($"batch/{Name}");
            return R.Data;
        }

        /// <summary>
        /// Запрос данных о заказах в партии
        /// </summary>
        /// <param name="name">Наименование партии</param>
        /// <param name="size">Количество записей на странице</param>
        /// <param name="sort">Критерии сортировки в формате: asc(по возрастанию) или desc (по убыванию).</param>
        /// <param name="page">Номер страниц</param>
        /// <returns></returns>
        public async Task<List<Order>> GetOrdersInBatch(string name, int? size = null, SortType sort = SortType.ASK, int? page = null)
        {
            var D = new Dictionary<string, string>
            {
                {"size",size.ToString()},
                {"sort",sort.ToQuery()},
                {"page",page.ToString()}
            };

            var R = await CallAPI<List<Order>>($"batch/{name}/shipment", D);
            return R.Data;
        }

        //TODO Создание партии из N заказов
        //TODO Изменение дня отправки в почтовое отделение
        //TODO Перенос заказов в партию
        //TODO Поиск партии по наименованию
        //TODO Поиск заказов с ШПИ
        //TODO Добавление заказов в партию
        //TODO Удаление заказов из партии
        //TODO Поиск заказа в партии по id
        //TODO Поиск заказов по идентификатору группы
        #endregion ПАРТИИ

        #region ДОКУМЕНТЫ
        //TODO Генерация пакета документации
        //TODO Генерация печатной формы Ф7п
        //TODO Генерация печатной формы Ф112ЭК
        //TODO Генерация печатных форм для заказа(до формирования партии)
        //TODO Генерация печатных форм для заказа
        //TODO Генерация печатной формы Ф103
        //TODO Подготовка и отправка электронной формы Ф103
        //TODO Генерация акта осмотра содержимого
        //TODO Генерация возвратного ярлыка на одной печатной странице
        #endregion ДОКУМЕНТЫ

        #region АРХИВ
        //TODO Запрос данных о партиях в архиве
        //TODO Перевод партии в архив
        //TODO Возврат партии из архива
        #endregion АРХИВ

        #region ПОИСК ОПС
        //TODO По индексу
        //TODO По адресу
        //TODO Почтовые сервисы ОПС
        //TODO Почтовые сервисы ОПС по идентификатору группы сервисов
        //TODO По координатам
        //TODO Поиск индексов в населенном пункте
        //TODO Выгрузка из паспорта ОПС
        #endregion ПОИСК ОПС

        #region ДОЛГОСРОЧНОЕ ХРАНЕНИЕ
        //TODO Запрос данных о заказах в архиве
        #endregion ДОЛГОСРОЧНОЕ ХРАНЕНИЕ

        #region ВОЗВРАТЫ
        //TODO Создание возвратного отправления для ранее созданного отправления
        //TODO Создание отдельного возвратного отправления
        //TODO Удаление отдельного возвратного отправления
        //TODO Редактирование отдельного возвратного отправления
        #endregion ВОЗВРАТЫ

        #region НАСТРОЙКИ
        //TODO Текущие точки сдачи
        //TODO Текущие настройки пользователя
        #endregion НАСТРОЙКИ

        #region ДАННЫЕ

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
            //TODO
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
            //TODO
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
            //TODO
            IRestRequest Request = new RestRequest("tariff", Method.POST);
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }

        #endregion ДАННЫЕ

        private async Task<string> Prototype()
        {
            IRestRequest Request = new RestRequest($"", Method.GET);
            var R = await Client.ExecuteGetAsync(Request);
            return R.Content;
        }
    }
}