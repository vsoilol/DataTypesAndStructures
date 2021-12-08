using System.Collections.Generic;

namespace Lab4
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