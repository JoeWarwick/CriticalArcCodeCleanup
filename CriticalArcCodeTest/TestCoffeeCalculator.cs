using CriticalArcCodeClean;
using CriticalArcCodeClean.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CriticalArcCodeTest
{
    [TestClass]
    public class TestCoffeeCalculator
    {
        [TestMethod]
        public void TestCoffeeCalculation()
        {
            // arrange
            var coffee = new Coffee
            {
                HasMilk = true,
                HasSprinkles = true,
                NumSugars = 0,
                IsLarge = true,
                MilkIsFoamed = true
            };

            var calc = new CoffeeCalculator(baseCost: 1.50, serviceCost: 1.30);
            calc.MilkBaseCost = 0.20;
            calc.MilkLrgCost = 0.05;
            calc.SprinkleCost = 0.02;
            calc.SugarCost = 0.05;
            calc.FoamCost = 0.10;

            // act
            var totalCost = calc.CalculateCost(coffee);

            // assert
            Assert.AreEqual(totalCost, 3.17);
        }
    }
}
