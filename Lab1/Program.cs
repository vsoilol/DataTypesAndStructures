using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Lab1
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double result;

            int coefficientNumbers = ConsoleProvider.ReturnEnteredNumber(ConsoleProvider.EnterDegreeOfPolynomial);
            int x = ConsoleProvider.ReturnEnteredNumber(ConsoleProvider.EnterX);
            int[] coefficients = new int[coefficientNumbers + 1];

            for (int i = 0; i < coefficients.Length; i++)
            {
                coefficients[i] = ConsoleProvider.ReturnEnteredNumber(string.Format(ConsoleProvider.EnterCoefficient, i + 1));
            }

            int[] reverseK = coefficients.Reverse().ToArray(); // В порядке убывания

            result = AlgorithmGorner.OrdinaryFunction(x, coefficients);
            Console.WriteLine($"Ordinary result: {result}");

            result =
                AlgorithmGorner.CalculateWithFor(x, reverseK, out int laborIntensity);
            Console.WriteLine($"Gorner with FOR: " +
                              $"{result} " +
                              $"labor intensity: {laborIntensity}");

            result =
                AlgorithmGorner.CalculateWithForNegativeStep(x, coefficients, out int laborIntensity1);
            Console.WriteLine($"Gorner with FOR negative step: " +
                              $"{result} " +
                              $"labor intensity: {laborIntensity1}");
        }
    }
}