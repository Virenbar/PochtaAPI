using System;

namespace PochtaAPI.STypes
{
    /// <summary>
    /// Адрес для нормализации
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Создаёт новый адрес
        /// </summary>
        public Address() { }

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
        public string ID { get; set; }

        /// <summary>
        /// Оригинальный адрес одной строкой
        /// </summary>
        public string OriginalAddress { get; set; }

        /// <summary>
        /// Код качества нормализации адреса
        /// </summary>
        public string QualityCode { get; set; }

        internal string AsJSON()
        {
            return $"{{\"id\":\"{ID}\",\"original-address\":\"{OriginalAddress}\"}}";
        }
    }
}