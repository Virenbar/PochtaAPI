using System;
using System.Runtime.Serialization;

namespace PochtaAPI.STypes
{
    /// <summary>
    /// Адрес для нормализации
    /// </summary>
    [DataContract]
    public class Address
    {
        /// <summary>
        /// Создаёт новый адрес
        /// </summary>
        /// <param name="address"></param>
        public Address(string address) : this(address, Guid.NewGuid().ToString()) { }

        /// <summary>
        /// Создаёт новый адрес c указанным ID
        /// </summary>
        /// <param name="address"></param>
        /// <param name="id"></param>
        public Address(string address, string id)
        {
            ID = id;
            OriginalAddress = address;
        }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Оригинальный адрес одной строкой
        /// </summary>
        [DataMember(Name = "original-address")]
        public string OriginalAddress { get; set; }
    }
}