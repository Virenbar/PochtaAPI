using System.Runtime.Serialization;

#pragma warning disable CS1591
//TODO Описание
namespace PochtaAPI.Models.Sending
{
    [DataContract]
    public class Account
    {
        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "blocked")]
        public bool Blocked { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "is-admin")]
        public bool IsAdmin { get; set; }

        [DataMember(Name = "legal-hid")]
        public string LegalHid { get; set; }

        [DataMember(Name = "org-inn")]
        public string OrgInn { get; set; }

        [DataMember(Name = "org-name")]
        public string OrgName { get; set; }
    }
}