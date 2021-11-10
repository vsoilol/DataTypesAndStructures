using System;
using System.Collections.Generic;

namespace Lab3
{
    public static class Storage
    {
        public static Baggage[] GenerateBaggages(int length)
        {
            var random = new Random();
            var baggages = new Baggage[length];

            for (var i = 0; i < length; i++)
            {
                baggages[i].ThingsAmount = random.Next(1, 20);
                baggages[i].ThingsWeight = Math.Round(random.NextDouble() * 40, 2);
            }

            return baggages;
        }
    }
}