using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    public static class SortAlgorithm
    {
        public static List<int> Items { get; private set; } = new List<int>();

        public static int NumberPermutations { get; private set; } = 0;

        public static void MakeSelectionSort(IEnumerable<int> items)
        {
            Items = items.ToList();
            NumberPermutations = 0;

            for (int i = 0; i < Items.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Items[j] < Items[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    SwapElements(i, minIndex);
                }
            }
        }

        public static void MakeCocktailSort(IEnumerable<int> items)
        {
            Items = items.ToList();
            NumberPermutations = 0;

            int left = 0, right = Items.Count - 1, last = right;
            do
            {
                for (int i = left; i < right; i++)
                {
                    if (Items[i] > Items[i + 1])
                    {
                        SwapElements(i, i + 1);
                        last = i;
                    }
                }

                right = last;

                for (int i = right; i > left; i--)
                {
                    if (Items[i] < Items[i - 1])
                    {
                        SwapElements(i, i - 1);
                        last = i;
                    }
                }

                left = last;
            } while (left < right);
        }

        private static void SwapElements(int firstPosition, int secondPosition)
        {
            if (firstPosition < Items.Count && secondPosition < Items.Count)
            {
                NumberPermutations++;
                var temp = Items[firstPosition];
                Items[firstPosition] = Items[secondPosition];
                Items[secondPosition] = temp;
            }
        }
    }
}