using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Lab4
{
    public class QuickSort
    {
        public QuickSort(Action<string> action)
        {
            DisplayInformation = action;
        }
        
        public event Action<string> DisplayInformation;
        
        public List<int> Items { get; private set; } = new List<int>();
        
        private readonly Stopwatch Stopwatch = new Stopwatch();
        
        private int _numberPermutations;

        public void MakeSortRecursion(IEnumerable<int> items)
        {
            _numberPermutations = 0;
            Items = items.ToList();
            DisplayInformation?.Invoke(Items.ToString(Information.OldArray));
            
            Stopwatch.Reset();
            Stopwatch.Start();
            QuickSortRecursion(0, Items.Count - 1);
            Stopwatch.Stop();
        }
        
        public void MakeSortWithoutRecursion(IEnumerable<int> items)
        {
            _numberPermutations = 0;
            Items = items.ToList();
            DisplayInformation?.Invoke(Items.ToString(Information.OldArray));
            Stopwatch.Reset();
            Stopwatch.Start();

            Stack<(int left, int right)> stack = new ();
            stack.Push((0, Items.Count - 1));

            while (stack.Count > 0)
            {
                var leftRight = stack.Pop();
                
                var pivot = Items[(leftRight.right - leftRight.left) / 2 + leftRight.left]; // берём центральный элемент

                int leftToRight = leftRight.left, rightToLeft = leftRight.right;

                while (leftToRight <= rightToLeft)
                {
                    // Пока элемент меньше центрального и не достигли последнего, двигаемся вправо
                    while (Items[leftToRight] < pivot && leftToRight <= leftRight.right)
                    {
                        leftToRight++;
                    }

                    // Пока элемент из правой части больше центрального и не достигли первого, двигаемся влево
                    while (Items[rightToLeft] > pivot && rightToLeft >= leftRight.left)
                    {
                        rightToLeft--;
                    }

                    if (leftToRight <= rightToLeft)
                    {
                        // Меняем элементы местами
                        SwapElements(leftToRight, rightToLeft);

                        leftToRight++; rightToLeft--;
                    }
                }
            
                // Рекурсивно вызываем этот же метод для дальнейшей сортировки
                if (leftToRight < leftRight.right)
                {
                    stack.Push((leftToRight, leftRight.right));
                }
                
                if (rightToLeft > leftRight.left)
                {
                    stack.Push((leftRight.left, rightToLeft));
                }
            }
            Stopwatch.Stop();
        }

        private void QuickSortRecursion(int left, int right)
        {
            var pivot = Items[(right - left) / 2 + left]; // берём центральный элемент

            int leftToRight = left, rightToLeft = right;

            while (leftToRight <= rightToLeft)
            {
                // Пока элемент меньше центрального и не достигли последнего, двигаемся вправо
                while (Items[leftToRight] < pivot && leftToRight <= right)
                {
                    leftToRight++;
                }

                // Пока элемент из правой части больше центрального и не достигли первого, двигаемся влево
                while (Items[rightToLeft] > pivot && rightToLeft >= left)
                {
                    rightToLeft--;
                }

                if (leftToRight <= rightToLeft)
                {
                    // Меняем элементы местами
                    SwapElements(leftToRight, rightToLeft);

                    leftToRight++; rightToLeft--;
                }
            }
            
            // Рекурсивно вызываем этот же метод для дальнейшей сортировки
            if (rightToLeft > left)
            {
                QuickSortRecursion(left, rightToLeft);
            }

            if (leftToRight < right)
            {
                QuickSortRecursion(leftToRight, right);
            }
        }

        private void SwapElements(int firstPosition, int secondPosition)
        {
            _numberPermutations++;
            (Items[firstPosition], Items[secondPosition]) = (Items[secondPosition], Items[firstPosition]);

            DisplayInformation?.Invoke(Items.ToString($"{_numberPermutations}) "));
        }
        
        public string ReturnInformationAboutSortAlgorithm(string sortAlgorithmText)
        {
            return "\n" + sortAlgorithmText +
                   $"\nКоличество перестановок {_numberPermutations}\n" +
                   $"Затраченное время {Stopwatch.Elapsed.ToString(@"fffffff").TrimStart('0')} милисекунд\n";
        }
    }
}