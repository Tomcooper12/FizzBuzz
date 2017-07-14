using System;
using System.Collections.Generic;
using FizzBuzz.Calculator;
using FizzBuzz.Output;

namespace FizzBuzz
{
    internal class FizzBuzzProcessor
    {
        /// <summary>
        /// Instance of IFizzBuzzCalculator
        /// </summary>
        private readonly IFizzBuzzCalculator _calculator;

        /// <summary>
        /// Instance of outputter
        /// </summary>
        private readonly IOutput _output;

        /// <summary>
        /// Constuctor Logic
        /// </summary>
        /// <param name="calculator"></param>
        internal FizzBuzzProcessor(IFizzBuzzCalculator calculator, IOutput output)
        {
            //dep inject
            _calculator = calculator;
            _output = output;
        }

        /// <summary>
        /// Processes a collection of integers
        /// </summary>
        /// <param name="collection"></param>
        internal void ProcessCollection(IEnumerable<int> collection)
        {
            foreach (var number in collection)
            {
                string response = _calculator.Calculate(number);
                _output.WriteOut(response);
            }
        }
    }
}
