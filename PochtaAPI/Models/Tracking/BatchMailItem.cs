using PochtaPacket;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PochtaAPI.Models.Tracking
{
    /// <summary>
    /// Почтовое отправление
    /// </summary>
    public class BatchMailItem
    {
        internal BatchMailItem(item Item)
        {
            History = Item.Operation.Select(I => new BatchHistoryRecord(I)).ToList();
            TrackCode = Item.Barcode;
        }

        /// <summary>
        /// История операций
        /// </summary>
        public List<BatchHistoryRecord> History { get; private set; }

        /// <summary>
        /// Статус получения
        /// </summary>
        public bool IsReceived { get => History.Last().OperTypeID == 2; }

        /// <summary>
        /// Дата отправки
        /// </summary>
        public DateTime? SendDate { get => History.First().Date; }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public string TrackCode { get; private set; }
    }
}