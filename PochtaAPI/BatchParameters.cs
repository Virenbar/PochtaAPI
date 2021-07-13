using PochtaAPI.Enums;

namespace PochtaAPI
{
    /// <summary>
    /// Параметры
    /// </summary>
    public class BatchParameters : BasicParameters
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