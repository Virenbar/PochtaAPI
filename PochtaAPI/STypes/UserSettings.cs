using System.Collections.Generic;
using System.Runtime.Serialization;

#pragma warning disable CS1591
//TODO Описание
namespace PochtaAPI.STypes
{
    [DataContract]
    public class UserSettings
    {
        [DataMember(Name = "account-admin")]
        public bool AccountAdmin { get; set; }

        [DataMember(Name = "accounts")]
        public IList<Account> Accounts { get; set; }

        [DataMember(Name = "address")]
        public Address Address { get; set; }

        [DataMember(Name = "admin-hid")]
        public string AdminHid { get; set; }

        [DataMember(Name = "agreement-number")]
        public string AgreementNumber { get; set; }

        [DataMember(Name = "api_enabled")]
        public bool ApiEnabled { get; set; }

        [DataMember(Name = "apig_access_token")]
        public string ApigAccessToken { get; set; }

        [DataMember(Name = "available-shipping-points")]
        public IList<ShippingPoint> AvailableShippingPoints { get; set; }

        [DataMember(Name = "blocked")]
        public bool Blocked { get; set; }

        [DataMember(Name = "brand-name")]
        public string BrandName { get; set; }

        [DataMember(Name = "contact-email")]
        public string ContactEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>Гениально</remarks>
        [DataMember(Name = "contact-phone")]
        public long ContactPhone { get; set; }

        [DataMember(Name = "def-envelope-type")]
        public string DefEnvelopeType { get; set; }

        [DataMember(Name = "def-payment-method")]
        public string DefPaymentMethod { get; set; }

        [DataMember(Name = "espp-code")]
        public string EsppCode { get; set; }

        [DataMember(Name = "hid")]
        public string Hid { get; set; }

        [DataMember(Name = "legal-hid")]
        public string LegalHid { get; set; }

        [DataMember(Name = "mail-rank")]
        public string MailRank { get; set; }

        [DataMember(Name = "mailing-option")]
        public IList<MailingOption> MailingOption { get; set; }

        [DataMember(Name = "org-inn")]
        public string OrgInn { get; set; }

        [DataMember(Name = "org-kpp")]
        public string OrgKpp { get; set; }

        [DataMember(Name = "org-name")]
        public string OrgName { get; set; }

        [DataMember(Name = "planned-monthly-number")]
        public int PlannedMonthlyNumber { get; set; }

        [DataMember(Name = "print-type")]
        public string PrintType { get; set; }

        [DataMember(Name = "regions")]
        public IList<string> Regions { get; set; }

        [DataMember(Name = "sender-name")]
        public string SenderName { get; set; }

        [DataMember(Name = "shipping-points")]
        public IList<ShippingPoint> ShippingPoints { get; set; }
    }
}