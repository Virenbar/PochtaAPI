using PochtaAPI.Enums;

namespace PochtaAPI
{
    /// <summary>
    /// Базовые параметры
    /// </summary>
    public class BasicParameters : Parameters
    {
        /// <summary>
        /// Номер страницы
        /// </summary>
        public int? Page
        {
            set => this[nameof(Page)] = value.ToString();
            get => this[nameof(Page)].GetValueOrNull<int>();
        }

        /// <summary>
        /// Количество записей на странице
        /// </summary>
        public int? Size
        {
            set => this[nameof(Size)] = value.ToString();
            get => this[nameof(Size)].GetValueOrNull<int>();
        }

        /// <summary>
        /// Критерий сортировки
        /// </summary>
        public SortType? Sort
        {
            set => this[nameof(Sort)] = value.ToString().ToLowerInvariant();
            get => this[nameof(Sort)].GetValueOrNull<SortType>();
        }
    }
}