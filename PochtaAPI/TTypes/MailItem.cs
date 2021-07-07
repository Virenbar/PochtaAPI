using Pochta;
using PochtaAPI.Enums;
using PochtaPacket;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PochtaAPI.TTypes
{
    /// <summary>
    /// Почтовое отправление
    /// </summary>
    public class MailItem
    {
        internal MailItem(getOperationHistoryResponse OHR)
        {
            History = OHR.OperationHistoryData.Select(O => new HistoryRecord(O)).ToList();
            var First = OHR.OperationHistoryData.FirstOrDefault();
            Mass = int.Parse(First.ItemParameters.Mass);
            Rate = decimal.Parse(First.FinanceParameters.MassRate) / 100;
            Recipient = First.UserParameters.Rcpn;
            TrackCode = First.ItemParameters.Barcode;
            Type = First.ItemParameters.ComplexItemName;
        }

        internal MailItem(item Item)
        {
            History = Item.Operation.Select(I => new HistoryRecord(I)).ToList();
            TrackCode = Item.Barcode;
        }

        /// <summary>
        /// История операций
        /// </summary>
        public List<HistoryRecord> History { get; private set; }

        /// <summary>
        /// Статус получения
        /// </summary>
        public bool IsReceived { get => History.Last().OperType == OperType.Receiving; }

        /// <summary>
        /// Масса
        /// </summary>
        public int Mass { get; private set; }

        /// <summary>
        /// Стоимость отправки
        /// </summary>
        public decimal Rate { get; private set; }

        /// <summary>
        /// Получатель
        /// </summary>
        public string Recipient { get; private set; }

        /// <summary>
        /// Дата отправки
        /// </summary>
        public DateTime? SendDate { get => History.FirstOrDefault()?.Date; }

        /// <summary>
        /// Дата получения
        /// </summary>
        public DateTime? ReceiveDate { get => History.FirstOrDefault(H => H.OperTypeID == 2)?.Date; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public string TrackCode { get; private set; }

        /// <summary>
        /// Тип
        /// </summary>
        public string Type { get; private set; }

        internal List<HistoryRecord> NoteHistory { get; set; }
    }
}