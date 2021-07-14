using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PochtaAPI.Enums;
using System.Runtime.Serialization;

#pragma warning disable CS1591
//TODO Описание
namespace PochtaAPI.STypes
{
    [DataContract]
    public class MailInfo
    {
        [DataMember(Name = "completeness-checking")]
        public bool? CompletenessChecking { get; set; }

        [DataMember(Name = "courier")]
        public bool? Courier { get; set; }

        [DataMember(Name = "declared-value")]
        public int? DeclaredValue { get; set; }

        [DataMember(Name = "dimension")]
        public Dimension Dimension { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "dimension-type")]
        public DimensionType? DimensionType { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "entries-type")]
        public string EntriesType { get; set; }

        [DataMember(Name = "fragile")]
        public bool? Fragile { get; set; }

        [DataMember(Name = "index-from")]
        public string IndexFrom { get; set; }

        [DataMember(Name = "index-to")]
        public string IndexTo { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "mail-category")]
        public MailCategory? MailCategory { get; set; }

        [DataMember(Name = "mail-direct")]
        public int? MailDirect { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "mail-type")]
        public MailType? MailType { get; set; }

        [DataMember(Name = "mass")]
        public int? Mass { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "notice-payment-method")]
        public string NoticePaymentMethod { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "payment-method")]
        public string PaymentMethod { get; set; }

        [DataMember(Name = "sms-notice-recipient")]
        public int? SmsNoticeRecipient { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "transport-type")]
        public string TransportType { get; set; }

        [DataMember(Name = "with-order-of-notice")]
        public bool? WithOrderOfNotice { get; set; }

        [DataMember(Name = "with-simple-notice")]
        public bool? WithSimpleNotice { get; set; }
    }
}