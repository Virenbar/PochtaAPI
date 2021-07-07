using PochtaAPI.Enums;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}