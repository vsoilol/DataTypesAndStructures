using System;

namespace Lab3
{
    public static class ConsoleProvider
    {
        private const string Separator = "--------------------------------------------------------------";
        public const string NoSuchBaggages = "Нет таких багажей";
        public const string NoBaggage = "Нет такого багажа";
        public const string EnterBaggageCount = "Введите количество багажей: ";
        
        public static int ReturnEnteredNumber(string text)
        {
            Console.Write(text);
            return int.Parse(Console.ReadLine());
        }
        
        public static void DisplayTextWithSeparator(string text)
        {
            text = text.TrimStart('\n').TrimEnd('\n');
            
            Console.WriteLine(Separator + "\n");
            Console.WriteLine(text + "\n");
            Console.WriteLine(Separator);
        }
    }
}