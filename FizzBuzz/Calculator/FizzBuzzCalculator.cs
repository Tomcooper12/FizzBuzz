namespace FizzBuzz.Calculator
{
    internal class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        public bool IsFactor(int value, int factor)
        {
            return (value % factor) == 0;
        }
    }
}
