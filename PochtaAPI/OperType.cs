namespace PochtaAPI

{
    /// <summary>
    /// Коды операций над отправлениями
    /// </summary>
    public enum OperType
    {
        /// <summary>
        /// Прием
        /// </summary>
        Sending = 1,

        /// <summary>
        /// Вручение
        /// </summary>
        Delivery = 2,

        /// <summary>
        /// Возврат
        /// </summary>
        Return = 3,

        /// <summary>
        /// Досылка почты
        /// </summary>
        Receiving = 4,

        /// <summary>
        /// Невручение
        /// </summary>
        NotReceiving = 5,

        /// <summary>
        /// Хранение
        /// </summary>
        Storage = 6,

        /// <summary>
        /// Временное хранение
        /// </summary>
        TempStorage = 7,

        /// <summary>
        /// Обработка
        /// </summary>
        Processing = 8,

        /// <summary>
        /// Импорт международной почты
        /// </summary>
        Import = 9,

        /// <summary>
        /// Экспорт международной почты
        /// </summary>
        Export = 10,

        /// <summary>
        /// Прием на таможню
        /// </summary>
        Customs = 11,

        /// <summary>
        /// Неудачная попытка вручения
        /// </summary>
        FailedDelivery = 12
    }
}