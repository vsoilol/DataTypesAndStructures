using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var arrayLength = ConsoleProvider.ReturnEnteredNumber(ConsoleProvider.EnterArrayLength);

            var random = new Random();
            var array = new int[arrayLength];

            for (var i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(-20, 20);
            }

            Console.WriteLine(array.ToString(ConsoleProvider.OldArray) + "\n");
            
            SortAlgorithm.MakeSelectionSort(array);
            var sortArray = SortAlgorithm.Items.ToArray();

            Console.WriteLine(SortAlgorithm.ReturnInformationAboutSortAlgorithm(ConsoleProvider.MakeWithSelectionSort));
            Console.WriteLine(sortArray.ToString(ConsoleProvider.SortArray) + "\n");

            Console.WriteLine(array.ToString(ConsoleProvider.OldArray) + "\n");
            
            SortAlgorithm.MakeCocktailSort(array);
            sortArray = SortAlgorithm.Items.ToArray();

            Console.WriteLine(SortAlgorithm.ReturnInformationAboutSortAlgorithm(ConsoleProvider.MakeWithCocktailSort));
            Console.WriteLine(sortArray.ToString(ConsoleProvider.SortArray) + "\n");
        }
    }
}