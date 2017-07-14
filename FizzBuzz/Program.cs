using System;
using System.Linq;
using FizzBuzz.Calculator;
using FizzBuzz.Output;

namespace FizzBuzz
{
    class Program
    {
        private const int MinValue = 1;
        private const int MaxValue = 100;

        static void Main(string[] args)
        {
            //setup app
            IFizzBuzzCalculator calculator = new FizzBuzzCalculator();
            IOutput output = new Outputter(Console.Out);
            var app = new FizzBuzzProcessor(calculator, output);

            //process collection
            app.ProcessCollection(Enumerable.Range(MinValue, MaxValue));

            //hold screen
            Console.ReadLine();
        }
    }
}
