using System.Runtime.Serialization;

namespace PochtaAPI.Models.Sending
{
    /// <summary>
    /// Нормализованные ФИО
    /// </summary>
    public class FIOClean : FIO
    {
        /// <summary>
        /// Отчество
        /// </summary>
        [DataMember(Name = "middle-name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Код качества нормализации ФИО
        /// </summary>
        [DataMember(Name = "quality-code")]
        public string QualityCode { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [DataMember(Name = "surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Приемлемое ли качество произведенной очистки?
        /// </summary>
        [DataMember(Name = "valid")]
        public bool Valid { get; set; }
    }
}