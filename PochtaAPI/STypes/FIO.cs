using System;
using System.Runtime.Serialization;

namespace PochtaAPI.STypes
{
    /// <summary>
    /// ФИО
    /// </summary>
    [DataContract]
    public class FIO
    {
        /// <summary>
        /// Создаёт новые ФИО
        /// </summary>
        public FIO() { }

        /// <summary>
        /// Создаёт новые ФИО
        /// </summary>
        public FIO(string fio) : this(fio, Guid.NewGuid().ToString()) { }

        /// <summary>
        /// Создаёт новые ФИО c указанным ID
        /// </summary>
        public FIO(string fio, string id)
        {
            ID = id;
            OriginalFIO = fio;
        }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [DataMember(Name = "id")]
        public string ID { get; set; }

        /// <summary>
        /// Оригинальные фамилия, имя , отчество одной строкой
        /// </summary>
        [DataMember(Name = "original-fio")]
        public string OriginalFIO { get; set; }
    }
}