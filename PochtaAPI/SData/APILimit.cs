namespace PochtaAPI.SData
{
    /// <summary>
    /// Текущее количество запросов по API
    /// </summary>
    public struct APILimit
    {
        /// <summary>
        /// Количество запросов по API разрешенных для клиента
        /// </summary>
        public int AllowedCount { get; set; }

        /// <summary>
        /// Текущее количество по API у клиента
        /// </summary>
        public int CurrentCount { get; set; }
    }
}