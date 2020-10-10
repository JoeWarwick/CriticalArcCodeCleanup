using CriticalArcCodeClean.Models;

namespace CriticalArcCodeClean
{
    public class CoffeeCalculator
    {
        public CoffeeCalculator(double baseCost = 1.50, double serviceCost = 1.30)
        {
            BaseCost = baseCost;
            ServiceCost = serviceCost;
        }

        public double BaseCost { get; }
        public double ServiceCost { get; }
        public double MilkBaseCost { get; set; } = 0.25;
        public double MilkLrgCost { get; set; } = 0.05;
        public double SugarCost { get; set; } = 0.10;
        public double FoamCost { get; set; } = 0.05;
        public double SprinkleCost { get; set; } = 0.05;

        public double CalculateCost(Coffee coffee)
        {
            // Start with basic Expresso
            double totalCost = this.BaseCost;

            // Milk 25c or 30c for large
            if (coffee.HasMilk)
            {
                totalCost += this.MilkBaseCost;
                if (coffee.IsLarge)
                {
                    totalCost += this.MilkLrgCost;
                }
            }

            // Calc sugar @ SugarCost each
            totalCost += this.SugarCost * coffee.NumSugars;

            // Milk Foaming 
            if (coffee.MilkIsFoamed)
                totalCost += this.FoamCost;

            // chocolate sprinkles
            if (coffee.HasSprinkles)
                totalCost += this.SprinkleCost;

            // Add service charge
            totalCost += this.ServiceCost;

            return totalCost;

        }

    }
}
