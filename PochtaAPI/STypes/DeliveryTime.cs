using System.Runtime.Serialization;

namespace PochtaAPI.STypes
{
    /// <summary>
    /// Время доставки
    /// </summary>
    [DataContract]
    public class DeliveryTime
    {
        /// <summary>
        /// Максимальное время доставки (дни)
        /// </summary>
        [DataMember(Name = "max-days")]
        public int MaxDays { get; set; }

        /// <summary>
        /// Минимальное время доставки (дни)
        /// </summary>
        [DataMember(Name = "min-days")]
        public int MinDays { get; set; }
    }
}