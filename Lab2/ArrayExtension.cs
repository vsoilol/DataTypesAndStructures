using System;

namespace Lab2
{
    public static class ArrayExtension
    {
        public static string ToString(this int[] array, string text)
        {
            string result = text;
            result += "[" + string.Join(" ", array) + "]";

            return result;
        }
    }
}