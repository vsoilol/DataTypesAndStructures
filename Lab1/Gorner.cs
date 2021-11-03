using System;
using System.Diagnostics;
using System.Linq;

namespace Lab1
{
    public static class AlgorithmGorner
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="k">Коэффициенты по возрастанию</param>
        /// <returns></returns>
        public static double OrdinaryFunction(int x, int[] k)
        {
            double result = 0;
            for (int i = 0; i < k.Length; i++)
            {
                result += k[i] * Math.Pow(x, i);
            }

            return result;
        }
        
        /// <summary>
        /// Алгоритм схемы Горнера с использованием арифметического цикла
        /// </summary>
        /// <param name="x"></param>
        /// <param name="k">Коэффициенты по убыванию</param>
        /// <returns></returns>
        public static double CalculateWithFor(int x, int[] k, out int laborIntensity)
        {
            double result = k[0];
            laborIntensity = 4;
            
            for (int i = 1; i < k.Length; i++)
            {
                laborIntensity += 2;
                result *= x;
                result += k[i];

                laborIntensity += 3;
            }

            return result;
        }
        
        /// <summary>
        /// Алгоритм схемы Горнера с арифметическим циклом с отрицательным шагом
        /// </summary>
        /// <param name="x"></param>
        /// <param name="k">Коэффициенты по возрастанию</param>
        /// <returns></returns>
        public static double CalculateWithForNegativeStep(int x, int[] k, out int laborIntensity)
        {
            double result = k[k.Length - 1];
            laborIntensity = 5;
            
            for (int i = k.Length - 2; i >= 0; i--)
            {
                laborIntensity += 2;
                result *= x;
                result += k[i];

                laborIntensity += 3;
            }

            return result;
        }
    }
}