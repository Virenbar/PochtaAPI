using PochtaAPI.Models.Sending;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PochtaAPI
{
    /// <summary>
    /// Клиент для работы с API отправки
    /// </summary>
    public class SendingClient : BaseClient
    {
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
            string URL = "https://otpravka-api.pochta.ru";
            string V1 = "1.0";
            EndPoint = $"{URL}/{V1}";
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Client.DefaultRequestHeaders.Add("Authorization", "AccessToken " + Token);
            Client.DefaultRequestHeaders.Add("X-User-Authorization", "Basic " + Key);
        }

        #region ЗАКАЗЫ

        /// <summary>
        /// Поиск заказа по идентификатору
        /// </summary>
        /// <param name="ID">Внутренний идентификатор отправления</param>
        /// <remarks>https://otpravka.pochta.ru/specification#/orders-search_order_byid</remarks>
        public Task<Order> GetOrderByID(int ID) => Get<Order>($"backlog/{ID}");

        /// <summary>
        /// Поиск заказа
        /// </summary>
        /// <param name="Query">Буквенно-цифровой идентификатор отправления</param>
        /// <remarks>https://otpravka.pochta.ru/specification#/orders-search_order</remarks>
        public Task<List<Order>> GetOrderByID(string Query)
        {
            var F = new Parameters { { "query", Query } };
            return Get<List<Order>>("backlog/search", F);
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
        public Task<List<Batch>> GetAllBatches() => GetAllBatches(new BatchParameters());

        /// <summary>
        /// Поиск всех партий
        /// </summary>
        /// <param name="filter">Фильтр записей</param>
        public Task<List<Batch>> GetAllBatches(BatchParameters filter) => Get<List<Batch>>("batch", filter);

        /// <summary>
        /// Поиск партии по наименованию
        /// </summary>
        public Task<Batch> GetBatchByName(string Name) => Get<Batch>($"batch/{Name}");

        /// <summary>
        /// Запрос данных о заказах в партии
        /// </summary>
        /// <param name="name">Наименование партии</param>
        public Task<List<Order>> GetOrdersInBatch(string name) => GetOrdersInBatch(name, new BasicParameters());

        /// <summary>
        /// Запрос данных о заказах в партии
        /// </summary>
        /// <param name="name">Наименование партии</param>
        /// <param name="filter">Фильтр записей</param>
        public Task<List<Order>> GetOrdersInBatch(string name, BasicParameters filter) => Get<List<Order>>($"batch/{name}/shipment", filter);

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

        /// <summary>
        /// Текущие точки сдачи
        /// </summary>
        /// <returns>Возвращает список текущих точек сдачи</returns>
        public Task<List<UserShippingPoint>> ShippingPoints => Get<List<UserShippingPoint>>("user-shipping-points");

        /// <summary>
        /// Текущие настройки пользователя
        /// </summary>
        public Task<UserSettings> UserSettings => Get<UserSettings>("settings");

        #endregion НАСТРОЙКИ

        #region ДАННЫЕ

        /// <summary>
        /// Нормализация адреса
        /// </summary>
        public Task<List<AddressClean>> CleanAddress(IList<AddressRequest> data) => Post<List<AddressClean>>("clean/address", data);

        /// <summary>
        /// Текущее количество запросов по API
        /// </summary>
        public Task<APILimit> GetAPILimit() => Get<APILimit>("settings/limit");

        /// <summary>
        /// Нормализация ФИО
        /// </summary>
        public Task<List<FIOClean>> CleanFIO(IList<FIO> data) => Post<List<FIOClean>>("clean/physical", data);

        /// <summary>
        /// Нормализация телефона
        /// </summary>
        public Task<List<PhoneClean>> CleanPhone(IList<Phone> data) => Post<List<PhoneClean>>("clean/phone", data);

        /// <summary>
        /// Расчет стоимости пересылки
        /// </summary>
        public Task<TariffInfo> CalculateTariff(MailInfo data) => Post<TariffInfo>("tariff", data);

        #endregion ДАННЫЕ
    }
}