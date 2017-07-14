using System;

namespace FizzBuzz.Calculator
{
    public class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        //constants
        internal const int FizzFactor = 3;
        internal const int BuzzFactor = 5;
        internal const string FizzKeyword = "Fizz";
        internal const string BuzzKeyword = "Buzz";

        public string Calculate(int number)
        {
            //return string
            string response = string.Empty;

            //check number for factors
            if (IsFactor(number, FizzFactor)) response += FizzKeyword;
            if (IsFactor(number, BuzzFactor)) response += BuzzKeyword;

            //return result
            return string.IsNullOrEmpty(response) ? number.ToString() : response;
        }

        private bool IsFactor(int value, int factor)
        {
            return (value % factor) == 0;
        }
    }
}
