using PochtaAPI.Interfaces;
using RestSharp;

namespace PochtaAPI
{
    internal class StringBody : IRequestParameter
    {
        private readonly string body;

        public StringBody(string body)
        {
            this.body = body;
        }

        public void ApplyParameters(IRestRequest request)
        {
            request.AddParameter("application/json", body, ParameterType.RequestBody);
        }
    }
}