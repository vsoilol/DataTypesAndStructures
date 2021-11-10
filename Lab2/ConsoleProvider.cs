using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public static class ConsoleProvider
    {
        public const string EnterArrayLength = "Введите длину массива: ";
        public const string OldArray = "Старый массив: ";
        public const string SortArray = "Отсортированный массив: ";
        public const string MakeWithSelectionSort = "Отсортировано с помощью прямого выбора при помощи поиска минимального элемента";
        public const string MakeWithCocktailSort = "Отсортировано с помощью шейкерной сортировкой";

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