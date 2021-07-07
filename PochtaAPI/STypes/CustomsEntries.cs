namespace PochtaAPI.STypes
{
    /// <summary>
    /// Таможенное вложение
    /// </summary>
    public class CustomsEntries
    {
        /// <summary>
        /// Количество
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Код страны происхождения
        /// </summary>
        public int CountryCode { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Код ТНВЭД
        /// </summary>
        public string TnvedCode { get; set; }

        /// <summary>
        /// Цена за единицу товара в копейках (вкл. НДС)
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Вес товара (в граммах)
        /// </summary>
        public int Weight { get; set; }
    }
}