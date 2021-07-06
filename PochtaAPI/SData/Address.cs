using System;

namespace PochtaAPI.SData
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
    internal class Class1
    {
        public string addresstype { get; set; }
        public string area { get; set; }
        public string building { get; set; }
        public string corpus { get; set; }
        public string hotel { get; set; }
        public string house { get; set; }
        public string id { get; set; }
        public string index { get; set; }
        public string letter { get; set; }
        public string location { get; set; }
        public string numaddresstype { get; set; }
        public string originaladdress { get; set; }
        public string place { get; set; }
        public string qualitycode { get; set; }
        public string region { get; set; }
        public string room { get; set; }
        public string slash { get; set; }
        public string street { get; set; }
        public string validationcode { get; set; }
    }
}