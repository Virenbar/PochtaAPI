namespace PochtaAPI.Enums
{
    /// <summary>
    /// Способ оплаты
    /// </summary>
    public enum PaymentMethod
    {
        /// <summary>
        /// Безналичный расчет
        /// </summary>
        CASHLESS,

        /// <summary>
        /// Оплата марками
        /// </summary>
        STAMP,

        /// <summary>
        /// Франкирование
        /// </summary>
        FRANKING,

        /// <summary>
        /// На франкировку
        /// </summary>
        TO_FRANKING,

        /// <summary>
        /// Знак онлайн оплаты
        /// </summary>
        ONLINE_PAYMENT_MARK
    }
}