using System;
using System.Diagnostics;
using System.Linq;

namespace Lab1
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            Stopwatch stopwatch = new Stopwatch();
            double result;
            int x = -5;
            double[] k = new double[400]; // В порядке возрастания

            for (int i = 0; i < k.Length; i++)
            {
                k[i] = random.Next(-50, 50);
            }

            double[] reverseK = k.Reverse().ToArray(); // В порядке убывания

            stopwatch.Start();
            result = AlgorithmGorner.OrdinaryFunction(x, k);
            stopwatch.Stop();

            Console.WriteLine($"Ordinary result: {result}, time: {stopwatch.Elapsed}");

            stopwatch.Reset();
            stopwatch.Start();
            result =
                AlgorithmGorner.CalculateRecursively(x, k);
            stopwatch.Stop();
            Console.WriteLine($"Gorner recursively: " +
                              $"{result} " +
                              $"time: {stopwatch.Elapsed}");

            stopwatch.Reset();
            stopwatch.Start();
            result =
                AlgorithmGorner.CalculateWithFor(x, reverseK);
            stopwatch.Stop();
            Console.WriteLine($"Gorner with FOR: " +
                              $"{result} " +
                              $"time: {stopwatch.Elapsed}");

            stopwatch.Reset();
            stopwatch.Start();
            result =
                AlgorithmGorner.CalculateWithForNegativeStep(x, k);
            stopwatch.Stop();
            Console.WriteLine($"Gorner with FOR negative step: " +
                              $"{result} " +
                              $"time: {stopwatch.Elapsed}");

            stopwatch.Reset();
            stopwatch.Start();
            result =
                AlgorithmGorner.CalculateWithWhile(x, reverseK);
            stopwatch.Stop();
            Console.WriteLine($"Gorner with While: " +
                              $"{result} " +
                              $"time: {stopwatch.Elapsed}");

            stopwatch.Reset();
            stopwatch.Start();
            result =
                AlgorithmGorner.CalculateWithWhileNegativeStep(x, k);
            stopwatch.Stop();
            Console.WriteLine($"Gorner with While negative step: " +
                              $"{result} " +
                              $"time: {stopwatch.Elapsed}");
        }
    }
}