using System.Runtime.Serialization;

namespace PochtaAPI.STypes
{
    /// <summary>
    /// Точка сдачи
    /// </summary>
    [DataContract]
    public class UserShippingPoint
    {
        /// <summary>
        /// Признак активации
        /// </summary>
        [DataMember(Name = "enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Индекс почтового отделения обслуживания
        /// </summary>
        [DataMember(Name = "operator-postcode")]
        public string OperatorPostcode { get; set; }

        /// <summary>
        /// Адрес ОПС
        /// </summary>
        [DataMember(Name = "ops-address")]
        public string OpsAddress { get; set; }
    }
}