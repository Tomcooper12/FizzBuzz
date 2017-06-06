using System;
using System.Linq;
using FizzBuzz.Calculator;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup app
            var app = new FizzBuzzApp(new FizzBuzzCalculator());

            //process collection
            app.ProcessCollection(Enumerable.Range(1, 100));

            //hold screen
            Console.ReadLine();
        }
    }
}
