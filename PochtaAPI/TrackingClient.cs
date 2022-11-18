using Pochta;
using PochtaAPI.Interfaces;
using PochtaAPI.Models.Tracking;
using PochtaPacket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace PochtaAPI
{
    /// <summary>
    /// Клиент для работы с трекингом
    /// </summary>
    /// <remarks>
    /// https://tracking.pochta.ru/specification
    /// </remarks>
    public class TrackingClient : ITrackingClient
    {
        private readonly AuthorizationHeader AH;
        private readonly FederalClientClient FCC;
        private readonly OperationHistory12Client OHC;

        static TrackingClient()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
        }

        /// <summary>
        /// Инициализирует новый клиент для работы с API
        /// </summary>
        /// <param name="Login">Логин</param>
        /// <param name="Password">Пароль</param>
        public TrackingClient(string Login, string Password)
        {
            OHC = new OperationHistory12Client();
            AH = new AuthorizationHeader { login = Login, password = Password };
            FCC = new FederalClientClient();
        }

        /// <summary>
        /// Кол-во обращений к API
        /// </summary>
        public int Usages { get; private set; }

        #region Одиночные методы

        /// <summary>
        /// Получить историю операций по отправлению
        /// </summary>
        /// <param name="TrackCode">Идентификатор РПО</param>
        public MailItem GetHistory(string TrackCode) => GetHistoryAsync(TrackCode, false).Result;

        /// <summary>
        /// Получить историю операций по отправлению
        /// </summary>
        /// <param name="TrackCode">Идентификатор РПО</param>
        public Task<MailItem> GetHistoryAsync(string TrackCode) => GetHistoryAsync(TrackCode, false);

        private async Task<MailItem> GetHistoryAsync(string TrackCode, bool IsNote)
        {
            if (!(TrackCode.Length == 13 || TrackCode.Length == 14)) { throw new ArgumentException("Некорректный идентификатор"); }

            var Responce = await HistoryAsync(TrackCode, false).ConfigureAwait(false);
            if (Responce.OperationHistoryData.Length == 0) { return null; }
            var MI = new MailItem(Responce);
            if (IsNote)
            {
                var Note = await HistoryAsync(TrackCode, true).ConfigureAwait(false);
                MI.NoteHistory = Note.OperationHistoryData.Select(O => new HistoryRecord(O)).ToList();
            }
            return MI;
        }

        private Task<getOperationHistoryResponse> HistoryAsync(string TrackCode, bool IsNote)
        {
            var R = OHC.getOperationHistoryAsync(
                new OperationHistoryRequest
                {
                    Barcode = TrackCode,
                    MessageType = IsNote ? 1 : 0
                },
                AH);
            Usages++;
            return R;
        }

        #endregion Одиночные методы

        #region Пакетные методы

        /// <summary>
        /// Получение информации об отправлениях по ранее полученному билету
        /// </summary>
        /// <param name="Ticket">Билет</param>
        public async Task<Batch> GetBatchAsync(Ticket Ticket)
        {
            var R = await FCC.getResponseByTicketAsync(new getResponseByTicketRequest(Ticket.ID, AH.login, AH.password)).ConfigureAwait(false);
            Usages++;
            if (R.error.ErrorTypeID != null) { throw new InvalidOperationException(R.error.ErrorName); }
            return new Batch(R.value);
        }

        /// <summary>
        /// Получение билета на подготовку информации по списку идентификаторов отправлений
        /// </summary>
        /// <param name="TrackCodes">Перечисление трек кодов</param>
        public async Task<Ticket> GetTicketAsync(IEnumerable<string> TrackCodes)
        {
            var File = new file { Item = TrackCodes.Select(S => new item { Barcode = S }).ToArray() };
            var R = await FCC.getTicketAsync(
                new getTicketRequest
                {
                    request = File,
                    login = AH.login,
                    password = AH.password
                }).ConfigureAwait(false);
            Usages++;
            if (R.error.ErrorTypeID != null) { throw new InvalidOperationException(R.error.ErrorName); }
            return new Ticket(R.value);
        }

        #endregion Пакетные методы
    }
}