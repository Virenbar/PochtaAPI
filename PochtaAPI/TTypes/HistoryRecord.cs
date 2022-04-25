using Pochta;
using PochtaAPI.Enums;
using PochtaPacket;
using System;

namespace PochtaAPI.TTypes
{
    /// <summary>
    /// Запись о операции
    /// </summary>
    public class HistoryRecord
    {
        internal HistoryRecord(OperationHistoryRecord OHR)
        {
            Address = $"{OHR.AddressParameters.OperationAddress.Description} ({OHR.AddressParameters.OperationAddress.Index})";
            OperationParameters OP = OHR.OperationParameters;
            Date = OP.OperDate;
            Operation = OP.OperType.Name;
            if (OP.OperAttr.Name?.Length > 0) { Operation += $" ({ OP.OperAttr.Name})"; }
            OperAttrID = OP.OperAttr.Id;
            OperTypeID = OP.OperType.Id;
            OperType = (OperType)OperTypeID;
        }

        internal HistoryRecord(operation O)
        {
            Date = DateTime.Parse(O.DateOper);
            Operation = O.OperName;
            OperAttrID = int.Parse(O.OperCtgID);
            OperTypeID = int.Parse(O.OperTypeID);
            OperType = (OperType)OperTypeID;
        }

        /// <summary>
        /// Адрес операции
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Дата операции
        /// </summary>
        public DateTime Date { get; private set; }

        /// <summary>
        /// Описание операции
        /// </summary>
        public string Operation { get; private set; }

        /// <summary>
        /// Код атрибута
        /// </summary>
        public int OperAttrID { get; private set; }

        /// <summary>
        /// Тип операции
        /// </summary>
        public OperType OperType { get; private set; }

        /// <summary>
        /// Код операции
        /// </summary>
        public int OperTypeID { get; private set; }

        /// <summary>
        /// Описание записи о операции
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{Date}: {Operation}";
    }
}