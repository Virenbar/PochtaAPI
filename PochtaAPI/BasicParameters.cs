using PochtaAPI.Enums;

namespace PochtaAPI
{
    /// <summary>
    /// Базовые параметры
    /// </summary>
    public class BasicParameters : Parameters
    {
        /// <summary>
        /// Инициализирует новые параметры
        /// </summary>
        public BasicParameters() { }

        /// <summary>
        /// Инициализирует новые параметры
        /// </summary>
        public BasicParameters(int? size, SortType sort, int? page) { }

        /// <summary>
        /// Номер страницы
        /// </summary>
        public int Page { set => this["page"] = value.ToString(); }

        /// <summary>
        /// Количество записей на странице
        /// </summary>
        public int Size { set => this["size"] = value.ToString(); }

        /// <summary>
        /// Критерий сортировки
        /// </summary>
        public SortType Sort { set => this["sort"] = value.ToString().ToLower(); }
    }
}