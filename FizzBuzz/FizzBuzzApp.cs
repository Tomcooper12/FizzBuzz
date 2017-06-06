using System;
using System.Collections.Generic;
using FizzBuzz.Calculator;

namespace FizzBuzz
{
    internal class FizzBuzzApp
    {
        //constants
        internal const int FizzFactor = 3;
        internal const int BuzzFactor = 5;
        internal const string FizzKeyword = "Fizz";
        internal const string BuzzKeyword = "Buzz";

        /// <summary>
        /// Instance of IFizzBuzzCalculator
        /// </summary>
        private readonly IFizzBuzzCalculator _calculator;

        /// <summary>
        /// Constuctor Logic
        /// </summary>
        /// <param name="calculator"></param>
        internal FizzBuzzApp(IFizzBuzzCalculator calculator)
        {
            //dep inject
            _calculator = calculator;
        }

        /// <summary>
        /// Processes a collection of integers
        /// </summary>
        /// <param name="collection"></param>
        internal void ProcessCollection(IEnumerable<int> collection)
        {
            foreach (var number in collection)
            {
                Console.WriteLine(GetFizzBuzz(number));
            }
        }

        /// <summary>
        /// Gets the fizz buzz string value for the given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        internal string GetFizzBuzz(int number)
        {
            //return string
            var response = string.Empty;

            //check number for factors
            if (_calculator.IsFactor(number, FizzFactor)) response += FizzKeyword;
            if (_calculator.IsFactor(number, BuzzFactor)) response += BuzzKeyword;

            //return result
            return string.IsNullOrEmpty(response) ? number.ToString() : response;
        }
    }
}
