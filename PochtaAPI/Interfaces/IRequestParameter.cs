using RestSharp;

namespace PochtaAPI.Interfaces
{
    internal interface IRequestParameter
    {
        void ApplyParameters(IRestRequest request);
    }
}