using Pochta;
using PochtaAPI.Enums;
using System;

namespace PochtaAPI.Models.Tracking
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
            Operation = OP.OperType.Name;
            if (OP.OperAttr.Name?.Length > 0) { Operation += $" ({ OP.OperAttr.Name})"; }
            //Operation
            OperationDate = OP.OperDate;
            OperationTypeID = OP.OperType.Id;
            OperationTypeName = OP.OperType.Name;
            OperationType = (OperationType)OperationTypeID;
            OperationAttributeID = OP.OperAttr.Id;
            OperationAttributeName = OP.OperAttr.Name;
        }

        /// <summary>
        /// Адрес операции
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Дата операции
        /// </summary>
        [Obsolete]
        public DateTime Date => OperationDate;

        /// <summary>
        /// Описание операции
        /// </summary>
        public string Operation { get; private set; }

        /// <summary>
        /// Код атрибута
        /// </summary>
        public int OperationAttributeID { get; private set; }

        /// <summary>
        /// Название атрибута
        /// </summary>
        public string OperationAttributeName { get; private set; }

        /// <summary>
        /// Дата операции
        /// </summary>
        public DateTime OperationDate { get; private set; }

        /// <summary>
        /// Тип операции
        /// </summary>
        public OperationType OperationType { get; private set; }

        /// <summary>
        /// Код операции
        /// </summary>
        public int OperationTypeID { get; private set; }

        /// <summary>
        /// Название операции
        /// </summary>
        public string OperationTypeName { get; private set; }

        /// <summary>
        /// Код атрибута
        /// </summary>
        [Obsolete]
        public int OperAttrID => OperationAttributeID;

        /// <summary>
        /// Тип операции
        /// </summary>
        [Obsolete]
        public OperationType OperType => OperationType;

        /// <summary>
        /// Код операции
        /// </summary>
        [Obsolete]
        public int OperTypeID => OperationTypeID;

        /// <summary>
        /// Описание записи о операции
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{OperationDate}: {Operation}";
    }
}