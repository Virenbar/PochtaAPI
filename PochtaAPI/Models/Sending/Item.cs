namespace PochtaAPI.Models.Sending
{
    /// <summary>
    /// Вложение
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Объявленная ценность (копейки)
        /// </summary>
        public int InsrValue { get; set; }

        /// <summary>
        /// Количество товара
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Цена за единицу товара в копейках (вкл. НДС)
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Ставка НДС: Без НДС(-1), 0, 10, 110, 20, 120
        /// </summary>
        public int VatRate { get; set; }
    }
}