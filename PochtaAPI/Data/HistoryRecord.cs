using Pochta;
using System;

namespace PochtaAPI.Data
{
	/// <summary>
	/// Запись о операции
	/// </summary>
	public class HistoryRecord
	{
		internal HistoryRecord(OperationHistoryRecord OHR)
		{
			Address = $"{OHR.AddressParameters.OperationAddress.Description} ({OHR.AddressParameters.OperationAddress.Index})";
			Date = OHR.OperationParameters.OperDate;
			Operation = OHR.OperationParameters.OperType.Name;
			if (OHR.OperationParameters.OperAttr.Name.Length > 0) { Operation += $" ({ OHR.OperationParameters.OperAttr.Name})"; };
			OperAttrID = OHR.OperationParameters.OperAttr.Id;
			OperTypeID = OHR.OperationParameters.OperType.Id;
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
		/// Код операции
		/// </summary>
		public int OperTypeID { get; private set; }

		public override string ToString() => $"{Date}: {Operation}";
	}
}