using PochtaAPI.Enums;

namespace PochtaAPI
{
    /// <summary>
    /// Фильтр
    /// </summary>
    public class BatchFilter : BasicFilter
    {
        /// <summary>
        /// Категория отправления
        /// </summary>
        public MailCategory MailCategory { set => this["mailCategory"] = value.ToString(); }

        /// <summary>
        /// Тип отправления
        /// </summary>
        public MailType MailType { set => this["mailType"] = value.ToString(); }
    }
}