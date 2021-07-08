using PochtaAPI.Enums;

namespace PochtaAPI
{
    /// <summary>
    /// Базовый фильтр
    /// </summary>
    public class BasicFilter : Filter
    {
        /// <summary>
        /// Инициализирует новый пустой базовый фильтр
        /// </summary>
        public BasicFilter() { }

        /// <summary>
        /// Инициализирует новый фильтр
        /// </summary>
        public BasicFilter(int? size, SortType sort, int? page) { }

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