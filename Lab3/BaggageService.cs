using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Lab3.Extensions;

namespace Lab3
{
    public class BaggageService
    {
        public IEnumerable<Baggage> GetBaggagesWithEqualAmountThings(IEnumerable<Baggage> baggages)
        {
            var sortBaggagesByAmount = baggages.SortByAmount();

            for (var i = 0; i < sortBaggagesByAmount.Length - 1; i++)
            {
                if (sortBaggagesByAmount[i].ThingsAmount == sortBaggagesByAmount[i + 1].ThingsAmount 
                    && Math.Abs(sortBaggagesByAmount[i].ThingsWeight - sortBaggagesByAmount[i + 1].ThingsWeight) <= 0.5)
                {
                    return new Baggage[]
                    {
                        sortBaggagesByAmount[i],
                        sortBaggagesByAmount[i + 1]
                    };
                }
            }

            return Array.Empty<Baggage>();
        }
        
        public Baggage GetBaggageWithOneAmount(IEnumerable<Baggage> baggages)
        {
            foreach (var baggage in baggages)
            {
                if (baggage.ThingsAmount == 1 && baggage.ThingsWeight < 30)
                {
                    return baggage;
                }
            }

            return new Baggage();
        }

        public string GetBaggagesInformation(IEnumerable<Baggage> baggages)
        {
            if (baggages.Count() == 0)
            {
                return ConsoleProvider.NoSuchBaggages;
            }
            
            var info = "\n";
            foreach (var baggage in baggages)
            {
                info += baggage + "\n";
            }

            return info;
        }
        
        public bool IsHaveEmptyProperties(Baggage baggage)
        {
            return baggage.ThingsAmount == 0 && baggage.ThingsWeight == 0;
        }
    }
}