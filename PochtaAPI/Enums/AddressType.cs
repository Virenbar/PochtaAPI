namespace PochtaAPI.Enums
{
    /// <summary>
    /// Тип адреса
    /// </summary>
    public enum AddressType
    {
        /// <summary>
        /// Стандартный(улица, дом, квартира)
        /// </summary>
        DEFAULT,

        /// <summary>
        /// Абонентский ящик
        /// </summary>
        PO_BOX,

        /// <summary>
        /// До востребования
        /// </summary>
        DEMAND,

        /// <summary>
        /// Для военных частей
        /// </summary>
        UNIT
    }
}