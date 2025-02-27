using Xunit;
using CalculatorApp.Models;

namespace CalculatorApp.Tests 
{
    public class CalculatorModelTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            var calculator = new CalculatorModel { Num1 = 5, Num2 = 3 };
            int result = calculator.Add();
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            var calculator = new CalculatorModel { Num1 = 10, Num2 = 4 };

            int result = calculator.Subtract();

            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            var calculator = new CalculatorModel { Num1 = 7, Num2 = 3 };

            int result = calculator.Multiply();

            Assert.Equal(21, result);
        }

        [Fact]
        public void Divide_ValidNumbers_ReturnsQuotient()
        {
            var calculator = new CalculatorModel { Num1 = 8, Num2 = 2 };

            string result = calculator.Divide();

            Assert.Equal("4", result);
        }

        [Fact]
        public void Divide_ByZero_ReturnsErrorMessage()
        {
            var calculator = new CalculatorModel { Num1 = 5, Num2 = 0 };

            string result = calculator.Divide();

            Assert.Equal("Error: Division by zero.", result);
        }
    }
}
