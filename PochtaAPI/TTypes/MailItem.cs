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
        private readonly OperationHistoryRecord First;

        internal MailItem(getOperationHistoryResponse OHR)
        {
            History = OHR.OperationHistoryData.Select(O => new HistoryRecord(O)).ToList();
            First = OHR.OperationHistoryData.FirstOrDefault();
            //Finance
            Rate = decimal.Parse(First.FinanceParameters.MassRate) / 100;
            //Item
            Mass = int.Parse(First.ItemParameters.Mass);
        }

        /// <summary>
        /// История операций
        /// </summary>
        public List<HistoryRecord> History { get; private set; }

        /// <summary>
        /// Содержит текстовое описание вида и категории отправления
        /// </summary>
        public string ComplexItemName => First?.ItemParameters.ComplexItemName;

        /// <summary>
        /// Статус получения
        /// </summary>
        public bool IsReceived => History.Last().OperationType == OperationType.Delivery;

        /// <summary>
        /// Код категории почтового отправления
        /// </summary>
        public int? MailCategoryID => First?.ItemParameters?.MailCtg.Id;

        /// <summary>
        /// Название категории почтового отправления
        /// </summary>
        public string MailCategoryName => First?.ItemParameters?.MailCtg.Name;

        /// <summary>
        /// Код разряда почтового отправления
        /// </summary>
        public int? MailRankID => First?.ItemParameters?.MailRank.Id;

        /// <summary>
        /// Название разряда почтового отправления
        /// </summary>
        public string MailRankName => First?.ItemParameters?.MailRank.Name;

        /// <summary>
        /// Код вида почтового отправления
        /// </summary>
        public int? MailTypeID => First?.ItemParameters?.MailType.Id;

        /// <summary>
        /// Название вида почтового отправления
        /// </summary>
        public string MailTypeName => First?.ItemParameters?.MailType.Name;

        /// <summary>
        /// Масса
        /// </summary>
        public int Mass { get; private set; }

        /// <summary>
        /// Код отметки почтового отправления
        /// </summary>
        public int? PostMarkID => First?.ItemParameters?.PostMark.Id;

        /// <summary>
        /// Наименование отметки почтового отправления
        /// </summary>
        public string PostMarkName => First?.ItemParameters?.PostMark.Name;

        /// <summary>
        /// Стоимость отправки
        /// </summary>
        public decimal Rate { get; private set; }

        /// <summary>
        /// Дата получения
        /// </summary>
        public DateTime? ReceiveDate => History.FirstOrDefault(H => H.OperationType == OperationType.Delivery)?.OperationDate;

        /// <summary>
        /// Получатель
        /// </summary>
        public string Recipient => First?.UserParameters?.Rcpn;

        /// <summary>
        /// Дата отправки
        /// </summary>
        public DateTime? SendDate => History.FirstOrDefault()?.OperationDate;

        /// <summary>
        /// Содержит данные об отправителе
        /// </summary>
        public string Sender => First?.UserParameters.Sndr;

        /// <summary>
        /// Идентификатор категории отправителя
        /// </summary>
        public int? SenderCategoryID => First?.UserParameters?.SendCtg.Id;

        /// <summary>
        /// Название категории отправителя
        /// </summary>
        public string SenderCategoryName => First?.UserParameters?.SendCtg.Name;

        /// <summary>
        /// Идентификатор почтового отправления
        /// </summary>
        public string TrackCode => First.ItemParameters.Barcode;

        /// <summary>
        /// Тип
        /// </summary>
        [Obsolete]
        public string Type => ComplexItemName;

        internal List<HistoryRecord> NoteHistory { get; set; }
    }
}