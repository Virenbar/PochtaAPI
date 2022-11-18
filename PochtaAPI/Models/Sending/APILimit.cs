using System.Runtime.Serialization;

namespace PochtaAPI.Models.Sending
{
    /// <summary>
    /// Текущее количество запросов по API
    /// </summary>
    [DataContract]
    public struct APILimit
    {
        /// <summary>
        /// Количество запросов по API разрешенных для клиента
        /// </summary>
        [DataMember(Name = "allowed-count")]
        public int AllowedCount { get; set; }

        /// <summary>
        /// Текущее количество по API у клиента
        /// </summary>
        [DataMember(Name = "current-count")]
        public int CurrentCount { get; set; }
    }
}