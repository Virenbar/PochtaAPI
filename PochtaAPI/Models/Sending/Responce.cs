using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PochtaAPI.Models.Sending
{
    /// <summary>
    /// Ошибка
    /// </summary>
    [DataContract]
    public class Error
    {
        /// <summary>
        /// Код ошибки
        /// </summary>
        [DataMember(Name = "error-code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Описание ошибки
        /// </summary>
        [DataMember(Name = "error-details")]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Индекс в исходном массиве
        /// </summary>
        [DataMember(Name = "position")]
        public int Position { get; set; }
    }
    /// <summary>
    /// Ответ от API
    /// </summary>
    [DataContract]
    public class Responce
    {
        /// <summary>
        /// Список ошибок
        /// </summary>
        [DataMember(Name = "errors")]
        public IList<Error> Errors { get; set; }

        /// <summary>
        /// Список идентификаторов успешно обработанных сущностей
        /// </summary>
        [DataMember(Name = "result-ids")]
        public IList<int> ResultIds { get; set; }
    }
}