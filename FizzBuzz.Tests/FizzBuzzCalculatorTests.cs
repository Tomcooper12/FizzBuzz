using FizzBuzz.Calculator;

namespace FizzBuzz.Tests
{
    using FizzBuzz.Output;
    using Xunit;
    public class FizzBuzzCalculatorTests
    {
        [Fact]
        public void Calculate_Factor_Of_Three()
        {
            //arrange
            int value = 27;
            var calculator = new FizzBuzzCalculator();

            //act
            string isFactor = calculator.Calculate(value);

            //assert
            Assert.Equal("Fizz", isFactor);
        }

        [Fact]
        public void Calculate_Factor_Of_Five()
        {
            //arrange
            int value = 25;
            var calculator = new FizzBuzzCalculator();

            //act
            string isFactor = calculator.Calculate(value);

            //assert
            Assert.Equal("Buzz", isFactor);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(37, "37")]
        [InlineData(64, "64")]
        [InlineData(98, "98")]
        [InlineData(27, "Fizz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(36, "Fizz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(50, "Buzz")]
        [InlineData(70, "Buzz")]
        public void Check_FizzBuzz_Result(int value, string expected)
        {
            //arrange
            IFizzBuzzCalculator calculator = new FizzBuzzCalculator();

            //act
            string response = calculator.Calculate(value);

            //assert
            Assert.Equal(response, expected);
        }
    }
}
