using PochtaAPI.Enums;
using PochtaAPI.STypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PochtaAPI
{
    internal static class Extensions
    {
        public static string FirstNotNull<TSource>(this IEnumerable<TSource> source, Func<TSource, string> predicate, string value)
        {
            return FirstNotNull(source, predicate) ?? value;
        }

        public static string FirstNotNull<TSource>(this IEnumerable<TSource> source, Func<TSource, string> predicate)
        {
            return source.Select(predicate).FirstOrDefault(X => !string.IsNullOrEmpty(X));
        }

        public static T? GetValueOrNull<T>(this string value) where T : struct
        {
            if (string.IsNullOrEmpty(value)) { return null; }
            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static string ToBody(this List<Address> LA) => LA.ToString();

        public static string ToQuery(this SortType SO) => SO.ToString().ToLower();

        public static string ToQuery(this MailType MT) => MT.ToString();

        public static string ToQuery(this MailCategory MC) => MC.ToString();
    }
}