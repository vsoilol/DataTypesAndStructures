using System;
using System.Collections.Generic;

namespace Lab2
{
    public static class ArrayExtension
    {
        public static string ToString(this IEnumerable<int> array, string text)
        {
            var result = text;
            result += "[" + string.Join(" ", array) + "]";

            return result;
        }
    }
}