﻿using PochtaAPI.Enums;
using PochtaAPI.STypes;
using System;
using System.Collections.Generic;

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

        public static T? GetValueOrNull<T>(this string value) where T : struct
        {
            if (string.IsNullOrEmpty(value)) { return null; }
            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}