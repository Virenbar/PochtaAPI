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
        public MailCategory? MailCategory
        {
            set => this[nameof(MailCategory)] = value.ToString();
            get => this[nameof(MailCategory)].GetValueOrNull<MailCategory>();
        }

        /// <summary>
        /// Тип отправления
        /// </summary>
        public MailType? MailType
        {
            set => this[nameof(MailType)] = value.ToString();
            get => this[nameof(MailType)].GetValueOrNull<MailType>();
        }
    }
}