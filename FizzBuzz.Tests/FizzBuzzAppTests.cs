using FizzBuzz.Calculator;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzAppTests
    {
        [Theory]
        [InlineData(27, "Fizz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(36, "Fizz")]
        [InlineData(30, "FizzBuzz")]
        [InlineData(50, "Buzz")]
        [InlineData(70, "Buzz")]
        public void Check_FizzBuzz_Result(int value, string expected)
        {
            //arrange
            var app = new FizzBuzzApp(new FizzBuzzCalculator());

            //act
            var response = app.GetFizzBuzz(value);

            //assert
            Assert.Equal(response, expected);
        }
    }
}
