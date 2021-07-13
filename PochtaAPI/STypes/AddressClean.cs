using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PochtaAPI.Enums;
using System.Runtime.Serialization;

#pragma warning disable CS1591 // Отсутствует комментарий XML для открытого видимого типа или члена
namespace PochtaAPI.STypes
{
    [DataContract]
    public class AddressClean
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "address-type")]
        public AddressType AddressType { get; set; }

        [DataMember(Name = "area")]
        public string Area { get; set; }

        [DataMember(Name = "building")]
        public string Building { get; set; }

        [DataMember(Name = "corpus")]
        public string Corpus { get; set; }

        [DataMember(Name = "hotel")]
        public string Hotel { get; set; }

        [DataMember(Name = "house")]
        public string House { get; set; }

        [DataMember(Name = "id")]
        public string ID { get; set; }

        [DataMember(Name = "index")]
        public string Index { get; set; }

        [DataMember(Name = "letter")]
        public string Letter { get; set; }

        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "num-address-type")]
        public string NumAddressType { get; set; }

        [DataMember(Name = "original-address")]
        public string OriginalAddress { get; set; }

        [DataMember(Name = "place")]
        public string Place { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "quality-code")]
        public AddressQuality QualityCode { get; set; }

        [DataMember(Name = "region")]
        public string Region { get; set; }

        [DataMember(Name = "room")]
        public string Room { get; set; }

        [DataMember(Name = "slash")]
        public string Slash { get; set; }

        [DataMember(Name = "street")]
        public string Street { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "validation-code")]
        public AddressValidation ValidationCode { get; set; }
    }
}