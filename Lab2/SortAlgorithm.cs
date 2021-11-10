using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Lab2
{
    public static class SortAlgorithm
    {
        public static List<int> Items { get; private set; } = new List<int>();

        private static int _numberPermutations;
        private static int _laborIntensity;
        
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        /// <summary>
        /// сортировка с помощью прямого выбора при помощи поиска
        /// минимального элемента. Сортировка выбором
        /// </summary>
        /// <param name="items"></param>
        public static void MakeSelectionSort(IEnumerable<int> items)
        {
            Items = items.ToList();
            _numberPermutations = 0;
            _laborIntensity = 2;

            Stopwatch.Reset();
            Stopwatch.Start();
            for (int i = 0; i < Items.Count - 1; i++)
            {
                _laborIntensity += 3;

                int minIndex = i;
                for (int j = i + 1; j < Items.Count; j++)
                {
                    _laborIntensity += 3;
                    if (Items[j] < Items[minIndex])
                    {
                        _laborIntensity++;
                        minIndex = j;
                    }
                }

                _laborIntensity++;
                if (i != minIndex)
                {
                    _laborIntensity += 7;
                    SwapElements(i, minIndex);
                }
            }
            Stopwatch.Stop();
        }

        /// <summary>
        /// Шейкерная сортировка
        /// </summary>
        /// <param name="items"></param>
        public static void MakeCocktailSort(IEnumerable<int> items)
        {
            Items = items.ToList();
            _numberPermutations = 0;
            _laborIntensity = 5;

            Stopwatch.Reset();
            Stopwatch.Start();
            int left = 0, right = Items.Count - 1, last = right;
            while (left < right)
            {
                _laborIntensity += 2;

                for (var i = left; i < right; i++)
                {
                    _laborIntensity += 3;
                    if (Items[i] > Items[i + 1])
                    {
                        _laborIntensity += 8;
                        SwapElements(i, i + 1);
                        last = i;
                    }
                }

                _laborIntensity++;
                right = last;

                _laborIntensity += 2;
                for (int i = right; i > left; i--)
                {
                    _laborIntensity += 3;
                    if (Items[i] < Items[i - 1])
                    {
                        _laborIntensity += 8;
                        SwapElements(i, i - 1);
                        last = i;
                    }
                }

                _laborIntensity++;
                left = last;
            }
            Stopwatch.Stop();
        }

        private static void SwapElements(int firstPosition, int secondPosition)
        {
            _numberPermutations++;
            var temp = Items[firstPosition];
            Items[firstPosition] = Items[secondPosition];
            Items[secondPosition] = temp;

            ConsoleProvider.ShowText(Items.ToString($"{_numberPermutations}) "));
        }

        public static string ReturnInformationAboutSortAlgorithm(string sortAlgorithmText)
        {
            return "\n" + sortAlgorithmText +
                   $"\nКоличество перестановок {_numberPermutations}\n" +
                   $"Трудоемкость {_laborIntensity}\n" +
                   $"Затраченное время {Stopwatch.Elapsed.ToString(@"fffffff").TrimStart('0')} милисекунд\n";
        }
    }
}