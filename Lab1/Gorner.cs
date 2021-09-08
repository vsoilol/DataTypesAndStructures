using System;
using System.Diagnostics;
using System.Linq;

namespace Lab1
{
    public static class AlgorithmGorner
    {
        public static double OrdinaryFunction(int x, double[] k)
        {
            double result = 0;
            for (int i = 0; i < k.Length; i++)
            {
                result += k[i] * Math.Pow(x, i);
            }

            return result;
        }
        
        public static double CalculateWithFor(int x, double[] k)
        {
            double result = k[0];
            
            for (int i = 1; i < k.Length; i++)
            {
                result *= x;
                result += k[i];
            }

            return result;
        }
        
        public static double CalculateWithForNegativeStep(int x, double[] k)
        {
            double result = k[^1];
            for (int i = k.Length - 2; i >= 0; i--)
            {
                result *= x;
                result += k[i];
            }

            return result;
        }
        
        public static double CalculateWithWhile(int x, double[] k)
        {
            double result = k[0];
            int i = 1;
            
            while (i < k.Length)
            {
                result *= x;
                result += k[i];
                i++;
            }

            return result;
        }
        
        public static double CalculateWithWhileNegativeStep(int x, double[] k)
        {
            double result = k[^1];
            int i = k.Length - 2;
            
            while (i >= 0)
            {
                result *= x;
                result += k[i];
                i--;
            }

            return result;
        }
        
        public static double CalculateRecursively(double x, double[] a, int i = 0)
        {
            if (i >= a.Length)
                return 0;
            return a[i] + x * CalculateRecursively(x, a, i + 1);
        }
    }
}