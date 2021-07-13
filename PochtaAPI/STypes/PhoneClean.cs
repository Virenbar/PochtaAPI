using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PochtaAPI.Enums;
using System.Runtime.Serialization;

namespace PochtaAPI.STypes
{
    /// <summary>
    /// Нормализованный номер телефона
    /// </summary>
    [DataContract]
    public class PhoneClean
    {
        /// <summary>
        /// Создаёт новый номер телефона
        /// </summary>
        public PhoneClean() { }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Оригинальные номер одной строкой
        /// </summary>
        [DataMember(Name = "original-phone")]
        public string OriginalPhone { get; set; }

        /// <summary>
        /// Код города
        /// </summary>
        [DataMember(Name = "phone-city-code")]
        public string PhoneCityCode { get; set; }

        /// <summary>
        /// Код страны
        /// </summary>
        [DataMember(Name = "phone-country-code")]
        public string PhoneCountryCode { get; set; }

        /// <summary>
        /// Добавочный номер
        /// </summary>
        [DataMember(Name = "phone-extension")]
        public string PhoneExtension { get; set; }

        /// <summary>
        /// Телефонный номер
        /// </summary>
        [DataMember(Name = "phone-number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Код качества нормализации телефона
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "quality-code")]
        public PhoneQuality QualityCode { get; set; }
    }
}