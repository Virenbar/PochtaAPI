using PochtaPacket;
using System;
using System.Collections.Generic;
using System.Text;

namespace PochtaAPI.Data
{
	/// <summary>
	/// Запись о операции
	/// </summary>
	public class BatchHistoryRecord
	{
		internal BatchHistoryRecord(operation O)
		{
			Date = DateTime.Parse(O.DateOper);
			Operation = O.OperName;
			OperAttrID = int.Parse(O.OperCtgID);
			OperTypeID = int.Parse(O.OperTypeID);
		}

		/// <summary>
		/// Дата и время операции (локальное)
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

		/// <summary>
		/// Описание записи о операции
		/// </summary>
		/// <returns></returns>
		public override string ToString() => $"{Date}: {Operation}";
	}
}