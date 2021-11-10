using System;
using Lab3.Extensions;

namespace Lab3
{
    public struct Baggage
    {
        public int ThingsAmount { get; set; }

        public double ThingsWeight { get; set; }

        public override string ToString()
        {
            return $"Количество вещей: {ThingsAmount}\n" +
                   $"Общий вес вещей: {ThingsWeight}\n";
        }
    }
}