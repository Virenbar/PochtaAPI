namespace PochtaAPI.STypes
{
    /// <summary>
    /// Время доставки
    /// </summary>
    public class DeliveryTime
    {
        /// <summary>
        /// Максимальное время доставки (дни)
        /// </summary>
        public int MaxDays { get; set; }

        /// <summary>
        /// Минимальное время доставки (дни)
        /// </summary>
        public int MinDays { get; set; }
    }
}