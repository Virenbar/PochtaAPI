using System;
using System.Collections.Generic;
using System.Text;

namespace PochtaAPI

{
	/// <summary>
	/// Коды операций над отправлениями
	/// </summary>
	public enum OperType
	{
		/// <summary>
		/// Прием
		/// </summary>
		Sending = 1,

		/// <summary>
		/// Вручение
		/// </summary>
		Receiving = 2
	}
}