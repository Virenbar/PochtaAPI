using PochtaAPI.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using PochtaAPI.STypes;

namespace PochtaAPI
{
    internal static class Extensions
    {
        public static string ToQuery(this SortType SO)
        {
            return SO.ToString().ToLower();
        }

        public static string ToQuery(this MailType MT)
        {
            return MT.ToString();
        }

        public static string ToQuery(this MailCategory MC)
        {
            return MC.ToString();
        }

        public static string ToBody(this List<Address> LA)
        {
            return LA.ToString();
        }

        public static void ApplyQuery(this IRestRequest RR, IDictionary<string, string> D)
        {
            if (D != null)
            {
                foreach (var KVPair in (Dictionary<string, string>)D)
                {
                    if (KVPair.Value != "") { RR.AddQueryParameter(KVPair.Key, KVPair.Value); }
                }
            }
        }
    }
}