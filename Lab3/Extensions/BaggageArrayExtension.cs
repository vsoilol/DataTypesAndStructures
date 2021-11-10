using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3.Extensions
{
    public static class BaggageArrayExtension
    {
        public static Baggage[] SortByAmount(this IEnumerable<Baggage> baggages)
        {
            var sortBaggagesArray = baggages.ToArray();
            for (int i = 0; i < sortBaggagesArray.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < sortBaggagesArray.Length; j++)
                {
                    if (sortBaggagesArray[j].ThingsAmount < sortBaggagesArray[minIndex].ThingsAmount)
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    SwapElements(ref sortBaggagesArray[i], ref sortBaggagesArray[minIndex]);
                }
            }

            return sortBaggagesArray;
        }

        private static void SwapElements(ref Baggage firstElement, ref Baggage secondElement)
        {
            var temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }
    }
}