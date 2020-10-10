using CriticalArcCodeClean.Models;
using System;

namespace CriticalArcCodeClean
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLarge = false, hasMilk = false, milkIsFoamed = false, hasSprinkles = false;
            int numSugars = 0;
            Console.WriteLine("Large? (true/false)");
            bool.TryParse(Console.ReadLine(), out isLarge);

            Console.WriteLine("Milk? (true/false)");
            bool.TryParse(Console.ReadLine(), out hasMilk);

            Console.WriteLine("How many sugars?");
            int.TryParse(Console.ReadLine(), out numSugars);

            Console.WriteLine("Foam the milk? (true/false)");
            bool.TryParse(Console.ReadLine(), out milkIsFoamed);

            Console.WriteLine("Add chocolate sprinkles? (true/false)");
            bool.TryParse(Console.ReadLine(), out hasSprinkles);

            Coffee exampleCoffee = new Coffee
            {
                IsLarge = isLarge,
                HasMilk = hasMilk,
                NumSugars = numSugars,
                MilkIsFoamed = milkIsFoamed,
                HasSprinkles = hasSprinkles
            };

            var calculator = new CoffeeCalculator();
            double cost = calculator.CalculateCost(exampleCoffee);
            Console.WriteLine(string.Format("Cost is ${0}",cost));
            Console.ReadKey(true);
        }
    }
}
