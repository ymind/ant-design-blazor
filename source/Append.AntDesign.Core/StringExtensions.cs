﻿using System;

namespace Append.AntDesign.Core
{
    public static class StringExtensions
    {
        public static string AddClassWhen(this string value, string cssClass, bool isValid) {
            if (isValid)
                return $"{value} {cssClass}";

            return value;
        }
    }
}
