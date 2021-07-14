using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PochtaAPI.Enums;
using System.Runtime.Serialization;

namespace PochtaAPI.STypes
{
    /// <summary>
    /// Нормализованный адрес
    /// </summary>
    [DataContract]
    public class AddressClean : Address
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Оригинальный адрес одной строкой
        /// </summary>
        [DataMember(Name = "original-address")]
        public string OriginalAddress { get; set; }

        /// <summary>
        /// Код качества нормализации адреса
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "quality-code")]
        public AddressQuality QualityCode { get; set; }

        /// <summary>
        /// Код проверки нормализации адреса
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "validation-code")]
        public AddressValidation ValidationCode { get; set; }
    }
}