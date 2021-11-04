using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int arrayLength = ConsoleProvider.ReturnEnteredNumber(ConsoleProvider.EnterArrayLength);

            var random = new Random();
            var array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(-20, 20);
            }

            Console.WriteLine(array.ToString(ConsoleProvider.OldArray) + "\n");

            SortAlgorithm.MakeSelectionSort(array);
            var sortArray = SortAlgorithm.Items.ToArray();

            Console.WriteLine(ConsoleProvider.MakeWithSelectionSort + $". Количество перестановок {SortAlgorithm.NumberPermutations}");
            Console.WriteLine(sortArray.ToString(ConsoleProvider.SortArray) + "\n");

            Console.WriteLine(array.ToString(ConsoleProvider.OldArray) + "\n");

            SortAlgorithm.MakeCocktailSort(array);
            sortArray = SortAlgorithm.Items.ToArray();

            Console.WriteLine(ConsoleProvider.MakeWithCocktailSort + $". Количество перестановок {SortAlgorithm.NumberPermutations}");
            Console.WriteLine(sortArray.ToString(ConsoleProvider.SortArray) + "\n");
        }
    }
}