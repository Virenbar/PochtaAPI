using RestSharp;
using System;
using System.Text;
using System.Threading.Tasks;

namespace PochtaAPI
{
	internal class SenderClient
	{
		private readonly IRestClient Client;

		public SenderClient(string Token, string Login, string Password) : this()
		{
			var Key = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Login}:{Password}"));
			Client.AddDefaultHeader("Authorization", Token);
			Client.AddDefaultHeader("X-User-Authorization", Key);
		}

		public SenderClient(string Token, string Key) : this()
		{
			Client.AddDefaultHeader("Authorization", Token);
			Client.AddDefaultHeader("X-User-Authorization", Key);
		}

		private SenderClient()
		{
			Client = new RestClient("https://otpravka-api.pochta.ru");
			Client.AddDefaultHeader("Content-Type", "application/json;charset=UTF-8");
		}

		public async Task SearchAsync()
		{
			IRestRequest Request = new RestRequest("/1.0/backlog/search", Method.GET);
			_ = await Client.ExecuteGetAsync(Request);
		}
	}
}