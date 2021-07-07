using System.Collections.Generic;
using System.Runtime.Serialization;

#pragma warning disable 1591
//TODO Добавить описание
namespace PochtaAPI.STypes
{
    [DataContract]
    public class Batch
    {
        [DataMember(Name = "batch-name")]
        public string BatchName { get; set; }

        [DataMember(Name = "batch-status")]
        public string BatchStatus { get; set; }

        [DataMember(Name = "batch-status-date")]
        public string BatchStatusDate { get; set; }

        [DataMember(Name = "combined-batch-mail-types")]
        public IList<string> CombinedBatchMailTypes { get; set; }

        [DataMember(Name = "courier-call-rate-with-vat")]
        public int CourierCallRateWithVat { get; set; }

        [DataMember(Name = "courier-call-rate-wo-vat")]
        public int CourierCallRateWoVat { get; set; }

        [DataMember(Name = "courier-order-statuses")]
        public IList<string> CourierOrderStatuses { get; set; }

        [DataMember(Name = "delivery-notice-payment-method")]
        public string DeliveryNoticePaymentMethod { get; set; }

        [DataMember(Name = "international")]
        public bool International { get; set; }

        [DataMember(Name = "list-number")]
        public int ListNumber { get; set; }

        [DataMember(Name = "list-number-date")]
        public string ListNumberDate { get; set; }

        [DataMember(Name = "mail-category")]
        public string MailCategory { get; set; }

        [DataMember(Name = "mail-category-text")]
        public string MailCategoryText { get; set; }

        [DataMember(Name = "mail-rank")]
        public string MailRank { get; set; }

        [DataMember(Name = "mail-type")]
        public string MailType { get; set; }

        [DataMember(Name = "mail-type-text")]
        public string MailTypeText { get; set; }

        [DataMember(Name = "notice-payment-method")]
        public string NoticePaymentMethod { get; set; }

        [DataMember(Name = "payment-method")]
        public string PaymentMethod { get; set; }

        [DataMember(Name = "postmarks")]
        public IList<string> Postmarks { get; set; }

        [DataMember(Name = "postoffice-address")]
        public string PostofficeAddress { get; set; }

        [DataMember(Name = "postoffice-code")]
        public string PostofficeCode { get; set; }

        [DataMember(Name = "postoffice-name")]
        public string PostofficeName { get; set; }

        [DataMember(Name = "shipment-avia-rate-sum")]
        public int ShipmentAviaRateSum { get; set; }

        [DataMember(Name = "shipment-avia-rate-vat-sum")]
        public int ShipmentAviaRateVatSum { get; set; }

        [DataMember(Name = "shipment-completeness-checking-rate-sum")]
        public int ShipmentCompletenessCheckingRateSum { get; set; }

        [DataMember(Name = "shipment-completeness-checking-rate-vat-sum")]
        public int ShipmentCompletenessCheckingRateVatSum { get; set; }

        [DataMember(Name = "shipment-count")]
        public int ShipmentCount { get; set; }

        [DataMember(Name = "shipment-ground-rate-sum")]
        public int ShipmentGroundRateSum { get; set; }

        [DataMember(Name = "shipment-ground-rate-vat-sum")]
        public int ShipmentGroundRateVatSum { get; set; }

        [DataMember(Name = "shipment-insure-rate-sum")]
        public int ShipmentInsureRateSum { get; set; }

        [DataMember(Name = "shipment-insure-rate-vat-sum")]
        public int ShipmentInsureRateVatSum { get; set; }

        [DataMember(Name = "shipment-inventory-rate-sum")]
        public int ShipmentInventoryRateSum { get; set; }

        [DataMember(Name = "shipment-inventory-rate-vat-sum")]
        public int ShipmentInventoryRateVatSum { get; set; }

        [DataMember(Name = "shipment-mass")]
        public int ShipmentMass { get; set; }

        [DataMember(Name = "shipment-mass-rate-sum")]
        public int ShipmentMassRateSum { get; set; }

        [DataMember(Name = "shipment-mass-rate-vat-sum")]
        public int ShipmentMassRateVatSum { get; set; }

        [DataMember(Name = "shipment-notice-rate-sum")]
        public int ShipmentNoticeRateSum { get; set; }

        [DataMember(Name = "shipment-notice-rate-vat-sum")]
        public int ShipmentNoticeRateVatSum { get; set; }

        [DataMember(Name = "shipment-sms-notice-rate-sum")]
        public int ShipmentSmsNoticeRateSum { get; set; }

        [DataMember(Name = "shipment-sms-notice-rate-vat-sum")]
        public int ShipmentSmsNoticeRateVatSum { get; set; }

        [DataMember(Name = "shipping-notice-type")]
        public string ShippingNoticeType { get; set; }

        [DataMember(Name = "transport-type")]
        public string TransportType { get; set; }

        [DataMember(Name = "use-online-balance")]
        public bool UseOnlineBalance { get; set; }

        [DataMember(Name = "wo-mass")]
        public bool WoMass { get; set; }
    }
}