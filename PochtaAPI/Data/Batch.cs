using PochtaPacket;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PochtaAPI.Data
{
	/// <summary>
	/// Пакет почтовых отправлений
	/// </summary>
	public class Batch
	{
		internal Batch(file File)
		{
			DatePrepared = DateTime.Parse(File.DatePreparation);
			File.Item.Select(I => new MailItem(I)).ToList();
		}

		/// <summary>
		/// Дата и время (московское) завершения обработки пакета
		/// </summary>
		public DateTime DatePrepared { get; private set; }

		/// <summary>
		/// Список почтовых отправлений
		/// </summary>
		public List<MailItem> Items { get; private set; }
	}
}