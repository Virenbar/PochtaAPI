using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PochtaAPI.Enums;
using System.Collections.Generic;
using System.Runtime.Serialization;

#pragma warning disable CS1591
//TODO Описание
namespace PochtaAPI.STypes
{
    [DataContract]
    public class ShippingPoint
    {
        [DataMember(Name = "additional-operator-postcode")]
        public string AdditionalOperatorPostcode { get; set; }

        [DataMember(Name = "additional-operator-postcodes")]
        public IList<string> AdditionalOperatorPostcodes { get; set; }

        [DataMember(Name = "address")]
        public Address Address { get; set; }

        [DataMember(Name = "available-additional-operator-postcodes")]
        public IList<string> AvailableAdditionalOperatorPostcodes { get; set; }

        [JsonProperty(ItemConverterType = typeof(StringEnumConverter))]
        [DataMember(Name = "available-mail-types")]
        public IList<MailType> AvailableMailTypes { get; set; }

        [DataMember(Name = "available-products")]
        public IList<AvailableProduct> AvailableProducts { get; set; }

        [DataMember(Name = "enabled")]
        public bool Enabled { get; set; }

        [DataMember(Name = "operator-postcode")]
        public string OperatorPostcode { get; set; }

        [DataMember(Name = "ops-address")]
        public string OpsAddress { get; set; }

        [DataMember(Name = "po-box")]
        public string PoBox { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "return-address-type")]
        public ReturnAddressType ReturnAddressType { get; set; }
    }
}