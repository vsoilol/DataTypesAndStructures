using System;
using System.Text;
using Lab3.Extensions;

namespace Lab3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.Clear();

                var baggageCount = ConsoleProvider.ReturnEnteredNumber(ConsoleProvider.EnterBaggageCount);
                
                var baggageService = new BaggageService();
                var baggages = Storage.GenerateBaggages(baggageCount);
                
                ConsoleProvider.DisplayTextWithSeparator(baggageService.GetBaggagesInformation(baggages));

                var baggagesWithEqualAmount = baggageService.GetBaggagesWithEqualAmountThings(baggages);
                ConsoleProvider.DisplayTextWithSeparator(baggageService.GetBaggagesInformation(baggagesWithEqualAmount));

                var baggageWithOneAmount = baggageService.GetBaggageWithOneAmount(baggages);

                ConsoleProvider.DisplayTextWithSeparator(baggageService.IsHaveEmptyProperties(baggageWithOneAmount)
                    ? ConsoleProvider.NoBaggage
                    : baggageWithOneAmount.ToString());


                Console.ReadLine();
            }
        }
    }
}