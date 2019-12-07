using day02.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace day02.Tests
{
    [TestClass]
    public class FuelCalculatorTests
    {
        [TestMethod]
        public void Calculate_for_mass_12_returns_2()
        {
            // Arrange
            var mass = 12;
            var targetFuel = 2;

            // Act
            var actualFuel = FuelCalculator.Calc(mass);
            
            // Assert
            Assert.AreEqual(targetFuel, actualFuel);
        }

        [TestMethod]
        public void Calculate_with_fuel_for_mass_1969_returns_966()
        {
            // Arrange
            var mass = 1969;
            var targetFuel = 966;

            // Act
            var actualFuel = FuelCalculator.CalcWithFuel(mass);

            System.Diagnostics.Debug.WriteLine($"targetFueld = {targetFuel}, actualFuel = {actualFuel}");

            // Assert
            Assert.AreEqual(targetFuel, actualFuel);
        }
    }
}
