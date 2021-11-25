using System;
using Xunit;

namespace TestCalculator
{
    public class Tests : IClassFixture<CalculatorFixture>
    {
        CalculatorFixture calculatorFixture;
        Calculator.Calculator calculator => calculatorFixture.calculator;
        public Tests(CalculatorFixture calculatorFixture)
        {
            this.calculatorFixture = calculatorFixture;
        }

        [Theory]
        [InlineData(5, 10, 15)]
        [InlineData(-5, -10, -15)]
        [InlineData(0, 0, 0)]
        public void CalculatorSum_EqualsExpected(double a, double b, double result)
        {
            Assert.Equal(result, calculator.Sum(a, b));
        }
        
        [Theory]
        [InlineData(5, 10, -5)]
        [InlineData(-5, -10, 5)]
        [InlineData(0, 0, 0)]
        public void CalculatorSubstract_EqualsExpected(double a, double b, double result)
        {
            Assert.Equal(result, calculator.Substract(a, b));
        }

        [Theory]
        [InlineData(5, 10, 50)]
        [InlineData(-5, -10, 50)]
        [InlineData(0, 0, 0)]
        public void CalculatorMultuply_EqualsExpected(double a, double b, double result)
        {
            Assert.Equal(result, calculator.Multiply(a, b));
        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(50, 10, 5)]
        [InlineData(0, 5, 0)]
        public void CalculatorDivide_EqualsExpected(double a, double b, double result)
        {
            Assert.Equal(result, calculator.Divide(a, b));
        }

        [Theory]
        [InlineData(10, 0)]
        [InlineData(50, 0)]
        [InlineData(0, 0)]
        public void CalculatorDivide_ThrowsDevideByZeroException(double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }

        [Theory]
        [InlineData(4, 2)]
        [InlineData(16, 4)]
        [InlineData(0, 0)]
        public void CalculatorSqrt_EqualsExpected(double a, double result)
        {
            Assert.Equal(result, calculator.Sqrt(a));
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-10)]
        public void CalculatorSqrt_ThrowsArgumentException(double a)
        {
            Assert.Throws<ArgumentException>(() => calculator.Sqrt(a));
        }
    }
}