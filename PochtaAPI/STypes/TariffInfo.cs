using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PochtaAPI.Enums;
using System.Runtime.Serialization;

#pragma warning disable CS1591
//TODO Описание
namespace PochtaAPI.STypes
{
    [DataContract]
    public class TariffInfo
    {
        [DataMember(Name = "avia-rate")]
        public TariffRate AviaRate { get; set; }

        [DataMember(Name = "completeness-checking-rate")]
        public TariffRate CompletenessCheckingRate { get; set; }

        [DataMember(Name = "delivery-time")]
        public DeliveryTime DeliveryTime { get; set; }

        [DataMember(Name = "fragile-rate")]
        public TariffRate FragileRate { get; set; }

        [DataMember(Name = "ground-rate")]
        public TariffRate GroundRate { get; set; }

        [DataMember(Name = "insurance-rate")]
        public TariffRate InsuranceRate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "notice-payment-method")]
        public PaymentMethod NoticePaymentMethod { get; set; }

        [DataMember(Name = "notice-rate")]
        public TariffRate NoticeRate { get; set; }

        [DataMember(Name = "oversize-rate")]
        public TariffRate OversizeRate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [DataMember(Name = "payment-method")]
        public PaymentMethod PaymentMethod { get; set; }

        [DataMember(Name = "sms-notice-recipient-rate")]
        public TariffRate SmsNoticeRecipientRate { get; set; }

        [DataMember(Name = "total-rate")]
        public int TotalRate { get; set; }

        [DataMember(Name = "total-vat")]
        public int TotalVat { get; set; }
    }

    [DataContract]
    public class TariffRate
    {
        [DataMember(Name = "rate")]
        public int Rate { get; set; }

        [DataMember(Name = "vat")]
        public int Vat { get; set; }
    }
}