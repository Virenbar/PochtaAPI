using System;

namespace PochtaAPI.TTypes
{
    /// <summary>
    /// Билет пакетного доступа
    /// </summary>
    public struct Ticket
    {
        internal Ticket(string ID)
        {
            this.ID = ID;
            Date = DateTime.Now;
        }

        /// <summary>
        /// Код билета
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// Дата создания билета
        /// </summary>
        public DateTime Date { get; private set; }
    }
}