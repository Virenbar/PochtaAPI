using System.Collections.Generic;
using System.Runtime.Serialization;

#pragma warning disable CS1591
//TODO Описание (Отсутствует в спецификации)
namespace PochtaAPI.STypes
{
    /// <summary>
    /// Опция отправления
    /// </summary>
    [DataContract]
    public class MailingOption
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "value")]
        public IList<MailingOptionValue> Value { get; set; }
    }
    [DataContract]
    public class MailingOptionValue
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}