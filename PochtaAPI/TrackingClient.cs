using Pochta;
using PochtaAPI.Data;
using System;
using System.Threading.Tasks;

namespace PochtaAPI
{
	/// <summary>
	/// Клиент для работы с трекингом
	/// </summary>
	/// <remarks>
	/// https://tracking.pochta.ru/specification
	/// </remarks>
	public class TrackingClient
	{
		private readonly AuthorizationHeader AH;
		private readonly OperationHistory12Client OHC;

		/// <summary>
		/// Инициализирует новый клиент для работы с API
		/// </summary>
		/// <param name="Login">Логин</param>
		/// <param name="Password">Пароль</param>
		public TrackingClient(string Login, string Password)
		{
			OHC = new OperationHistory12Client();
			AH = new AuthorizationHeader() { login = Login, password = Password };
		}

		/// <summary>
		/// Кол-во обращений к API
		/// </summary>
		public int Usages { get; private set; }

		/// <summary>
		/// Получить историю операций по отправлению
		/// </summary>
		/// <param name="TrackCode">Идентификатор РПО</param>
		/// <returns></returns>
		public Task<MailItem> GetHistoryAsync(string TrackCode)
		{
			return GetHistoryAsync(TrackCode, false);
		}

		private async Task<MailItem> GetHistoryAsync(string TrackCode, bool IsNote = false)
		{
			if (!(TrackCode.Length == 13 || TrackCode.Length == 14)) { throw new ArgumentException("Некорретный идетификатор"); };

			var Responce = await HistoryAsync(TrackCode, false);
			Usages++;
			if (Responce.OperationHistoryData.Length == 0) { return null; };
			if (IsNote)
			{
				var NoteResponce = await HistoryAsync(TrackCode, true);
				Usages++;
			}
			return new MailItem(Responce);
		}

		private Task<getOperationHistoryResponse> HistoryAsync(string TrackCode, bool IsNote = false)
		{
			return OHC.getOperationHistoryAsync(
				new OperationHistoryRequest()
				{
					Barcode = TrackCode,
					MessageType = IsNote ? 1 : 0
				},
				AH);
		}
	}
}