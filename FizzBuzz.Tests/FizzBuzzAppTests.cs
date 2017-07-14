using FizzBuzz.Calculator;
using FizzBuzz.Output;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzAppTests
    {
        private const int MinValue = 1;
        private const int MaxValue = 100;

        [Fact]
        public void Check_App_Process_Collection()
        {
            //arrange
            Mock<IOutput> output = new Mock<IOutput>();
            Mock<IFizzBuzzCalculator> calculator = new Mock<IFizzBuzzCalculator>();
            calculator.Setup(c => c.Calculate(It.IsAny<int>())).Returns(It.IsAny<string>());
            FizzBuzzProcessor processor = new FizzBuzzProcessor(calculator.Object, output.Object);
            IEnumerable<int> range = Enumerable.Range(MinValue, MaxValue);

            //act
            processor.ProcessCollection(range);

            //assert
            output.Verify(m => m.WriteOut(It.IsAny<string>()));
        }

    }
}
