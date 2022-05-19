using PochtaAPI.Enums;
using PochtaAPI.STypes;
using System;
using System.Collections.Generic;

namespace PochtaAPI
{
    internal static class Extensions
    {
        public static string ToQuery(this SortType SO) => SO.ToString().ToLower();

        public static string ToQuery(this MailType MT) => MT.ToString();

        public static string ToQuery(this MailCategory MC) => MC.ToString();

        public static string ToBody(this List<Address> LA) => LA.ToString();

        public static T? GetValueOrNull<T>(this string value) where T : struct
        {
            if (string.IsNullOrEmpty(value)) { return null; }
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}