using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PochtaAPI.Enums;
using System.Runtime.Serialization;

#pragma warning disable CS1591
//TODO Описание
namespace PochtaAPI.STypes
{
    [DataContract]
    public class AvailableProduct
    {
        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "mail-category")]
        public MailCategory MailCategory { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "mail-type")]
        public MailType MailType { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "product-type")]
        public ProductType ProductType { get; set; }

        [DataMember(Name = "sms-notice-recipient-enabled")]
        public bool SmsNoticeRecipientEnabled { get; set; }
    }
}