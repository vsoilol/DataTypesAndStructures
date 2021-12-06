using System;

namespace Lab4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var quickSort = new QuickSort(ConsoleProvider.ShowText);
            //var array = new[] {5, 9, 7, 1, 10, 12, 22, 8};
            
            var arrayLength = ConsoleProvider.ReturnEnteredNumber(Information.EnterArrayLength);

            var random = new Random();
            var array = new int[arrayLength];

            for (var i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(-20, 20);
            }

            quickSort.MakeSortRecursion(array);
            Console.WriteLine(quickSort.ReturnInformationAboutSortAlgorithm(Information.MakeWithQuickSortRecursion));
            
            Console.WriteLine(Environment.NewLine);
            
            quickSort.MakeSortWithoutRecursion(array);
            Console.WriteLine(quickSort.ReturnInformationAboutSortAlgorithm(Information.MakeWithQuickSortWithoutRecursion));
        }
    }
}