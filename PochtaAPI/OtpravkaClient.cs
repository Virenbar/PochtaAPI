using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace PochtaAPI
{
	internal class OtpravkaClient
	{
		private readonly IRestClient Client;

		public OtpravkaClient(string Token, string Login, string Password) : this()
		{
			var Key = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Login}:{Password}"));
			Client.AddDefaultHeader("Authorization", Token);
			Client.AddDefaultHeader("X-User-Authorization", Key);
		}

		public OtpravkaClient(string Token, string Key) : this()
		{
			Client.AddDefaultHeader("Authorization", Token);
			Client.AddDefaultHeader("X-User-Authorization", Key);
		}

		private OtpravkaClient()
		{
			Client = new RestClient("https://otpravka-api.pochta.ru");
			Client.AddDefaultHeader("Content-Type", "application/json;charset=UTF-8");
		}

		public async Task SearchAsync()
		{
			IRestRequest Request = new RestRequest("/1.0/backlog/search", Method.GET);
			var T = await Client.ExecuteGetAsync(Request);
		}
	}
}