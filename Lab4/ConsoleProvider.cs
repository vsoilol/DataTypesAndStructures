using System;

namespace Lab4
{
    public static class ConsoleProvider
    {
        public static int ReturnEnteredNumber(string text)
        {
            Console.Write(text);
            return int.Parse(Console.ReadLine() ?? string.Empty);
        }
        
        public static void ShowText(string text)
        {
            Console.WriteLine(text);
        }
    }
}