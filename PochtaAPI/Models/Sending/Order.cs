using System.Runtime.Serialization;

#pragma warning disable 1591
//TODO Добавить описание
namespace PochtaAPI.Models.Sending
{
    [DataContract]
    public class Order
    {
        [DataMember(Name = "address-type-to")]
        public string AddressTypeTo { get; set; }

        [DataMember(Name = "area-to")]
        public string AreaTo { get; set; }

        [DataMember(Name = "brand-name")]
        public string BrandName { get; set; }

        [DataMember(Name = "building-to")]
        public string BuildingTo { get; set; }

        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        [DataMember(Name = "completeness-checking")]
        public bool CompletenessChecking { get; set; }

        [DataMember(Name = "corpus-to")]
        public string CorpusTo { get; set; }

        [DataMember(Name = "courier")]
        public bool Courier { get; set; }

        [DataMember(Name = "customs-declaration")]
        public CustomsDeclaration CustomsDeclaration { get; set; }

        [DataMember(Name = "delivery-with-cod")]
        public bool DeliveryWithCod { get; set; }

        [DataMember(Name = "dimension")]
        public Dimension Dimension { get; set; }

        [DataMember(Name = "envelope-type")]
        public string EnvelopeType { get; set; }

        [DataMember(Name = "fragile")]
        public bool Fragile { get; set; }

        [DataMember(Name = "given-name")]
        public string GivenName { get; set; }

        [DataMember(Name = "goods")]
        public Goods Goods { get; set; }

        [DataMember(Name = "hotel-to")]
        public string HotelTo { get; set; }

        [DataMember(Name = "house-to")]
        public string HouseTo { get; set; }

        [DataMember(Name = "index-to")]
        public int IndexTo { get; set; }

        [DataMember(Name = "insr-value")]
        public int InsrValue { get; set; }

        [DataMember(Name = "inventory")]
        public bool Inventory { get; set; }

        [DataMember(Name = "letter-to")]
        public string LetterTo { get; set; }

        [DataMember(Name = "location-to")]
        public string LocationTo { get; set; }

        [DataMember(Name = "mail-category")]
        public string MailCategory { get; set; }

        [DataMember(Name = "mail-direct")]
        public int MailDirect { get; set; }

        [DataMember(Name = "mail-type")]
        public string MailType { get; set; }

        [DataMember(Name = "manual-address-input")]
        public bool ManualAddressInput { get; set; }

        [DataMember(Name = "mass")]
        public int Mass { get; set; }

        [DataMember(Name = "middle-name")]
        public string MiddleName { get; set; }

        [DataMember(Name = "no-return")]
        public bool NoReturn { get; set; }

        [DataMember(Name = "notice-payment-method")]
        public string NoticePaymentMethod { get; set; }

        [DataMember(Name = "num-address-type-to")]
        public string NumAddressTypeTo { get; set; }

        [DataMember(Name = "office-to")]
        public string OfficeTo { get; set; }

        [DataMember(Name = "order-num")]
        public string OrderNum { get; set; }

        [DataMember(Name = "payment")]
        public int Payment { get; set; }

        [DataMember(Name = "payment-method")]
        public string PaymentMethod { get; set; }

        [DataMember(Name = "place-to")]
        public string PlaceTo { get; set; }

        [DataMember(Name = "postoffice-code")]
        public string PostofficeCode { get; set; }

        [DataMember(Name = "raw-address")]
        public string RawAddress { get; set; }

        [DataMember(Name = "recipient-name")]
        public string RecipientName { get; set; }

        [DataMember(Name = "region-to")]
        public string RegionTo { get; set; }

        [DataMember(Name = "room-to")]
        public string RoomTo { get; set; }

        [DataMember(Name = "slash-to")]
        public string SlashTo { get; set; }

        [DataMember(Name = "sms-notice-recipient")]
        public int SmsNoticeRecipient { get; set; }

        [DataMember(Name = "str-index-to")]
        public string StrIndexTo { get; set; }

        [DataMember(Name = "street-to")]
        public string StreetTo { get; set; }

        [DataMember(Name = "surname")]
        public string Surname { get; set; }

        [DataMember(Name = "tel-address")]
        public int TelAddress { get; set; }

        [DataMember(Name = "transport-mode")]
        public string TransportMode { get; set; }

        [DataMember(Name = "transport-type")]
        public string TransportType { get; set; }

        [DataMember(Name = "vladenie-to")]
        public string VladenieTo { get; set; }

        [DataMember(Name = "with-order-of-notice")]
        public bool WithOrderOfNotice { get; set; }

        [DataMember(Name = "with-simple-notice")]
        public bool WithSimpleNotice { get; set; }

        [DataMember(Name = "wo-mail-rank")]
        public bool WoMailRank { get; set; }
    }
}