using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public static class ConsoleProvider
    {
        public const string EnterDegreeOfPolynomial = "Введите степень многочлена: ";
        public const string EnterCoefficient = "Введите {0} коэффициент: ";
        public const string EnterX = "Введите x: ";

        public static int ReturnEnteredNumber(string text)
        {
            Console.Write(text);
            return int.Parse(Console.ReadLine());
        }
    }
}
