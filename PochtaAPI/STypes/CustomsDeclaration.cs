namespace PochtaAPI.STypes
{
    /// <summary>
    /// Таможенная декларация
    /// </summary>
    public class CustomsDeclaration
    {
        /// <summary>
        /// Код валюты
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Список вложений
        /// </summary>
        public CustomsEntries[] CustomsEntries { get; set; }

        /// <summary>
        /// Категория вложения
        /// </summary>
        public string EntriesType { get; set; }

        /// <summary>
        /// Приложенные документы: сертификат
        /// </summary>
        public bool WithCertificate { get; set; }

        /// <summary>
        /// Приложенные документы: счет-фактура
        /// </summary>
        public bool WithInvoice { get; set; }

        /// <summary>
        /// Приложенные документы: лицензия
        /// </summary>
        public bool WithLicense { get; set; }
    }
}