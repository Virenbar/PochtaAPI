using System;
using System.Runtime.Serialization;

namespace PochtaAPI.Models.Sending
{
    /// <summary>
    /// Номер телефона
    /// </summary>
    [DataContract]
    public class Phone
    {
        /// <summary>
        /// Создаёт новый номер телефона
        /// </summary>
        public Phone(string phone) : this(phone, Guid.NewGuid().ToString()) { }

        /// <summary>
        /// Создаёт новый номер телефона c указанным ID
        /// </summary>
        public Phone(string phone, string id)
        {
            ID = id;
            OriginalPhone = phone;
        }

        /// <summary>
        /// Область/край трелефонного номера
        /// </summary>
        [DataMember(Name = "area")]
        public string Area { get; set; }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Оригинальные номер одной строкой
        /// </summary>
        [DataMember(Name = "original-phone")]
        public string OriginalPhone { get; set; }

        /// <summary>
        /// Город телефонного номера
        /// </summary>
        [DataMember(Name = "place")]
        public string Place { get; set; }

        /// <summary>
        /// Регион телефонного номера
        /// </summary>
        [DataMember(Name = "region")]
        public string Region { get; set; }
    }
}