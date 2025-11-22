using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLib_SoldatovaPA;

namespace CalcTests_SoldatovaPA
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculateExpression_ValidExpression_ReturnsCorrectResult()
        {
            // Arrange
            double expected = (9.0 / 3.0) * 4.0 / 3.0 / 2.0 + 1.0;

            // Act
            double actual = Calculator.CalculateExpression();

            // Assert
            Assert.AreEqual(expected, actual, 0.0001, "Результат вычисления неверный");
        }

        [TestMethod]
        public void CalculateExpression_CheckManualCalculation_ReturnsThree()
        {
            // Ручной расчет:
            // (9/3) = 3
            // 3 * 4 = 12
            // 12 / 3 = 4
            // 4 / 2 = 2
            // 2 + 1 = 3

            // Act
            double result = Calculator.CalculateExpression();

            // Assert
            Assert.AreEqual(3.0, result, "Результат должен быть равен 3");
        }
    }
}
