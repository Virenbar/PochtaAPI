using PochtaAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PochtaAPI.Interfaces
{
	internal interface ITrackingClient
	{
		MailItem GetHistory(string TrackCode);

		Task<MailItem> GetHistoryAsync(string TrackCode);

		Task<Batch> GetBatchAsync(Ticket Ticket);

		Task<Ticket> GetTicketAsync(IEnumerable<string> TrackCodes);
	}
}