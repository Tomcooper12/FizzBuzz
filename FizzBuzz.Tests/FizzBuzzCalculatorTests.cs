using FizzBuzz.Calculator;

namespace FizzBuzz.Tests
{
    using Xunit;
    public class FizzBuzzCalculatorTests
    {
        [Fact]
        public void Calculate_Factor_Of_Three()
        {
            //arrange
            int value = 27;
            int factor = 3;
            var calculator = new FizzBuzzCalculator();

            //act
            bool isFactor = calculator.IsFactor(value, factor);

            //assert
            Assert.True(isFactor);
        }

        [Fact]
        public void Calculate_Factor_Of_Five()
        {
            //arrange
            int value = 25;
            int factor = 5;
            var calculator = new FizzBuzzCalculator();

            //act
            bool isFactor = calculator.IsFactor(value, factor);

            //assert
            Assert.True(isFactor);
        }
    }
}
