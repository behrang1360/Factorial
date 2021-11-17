using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace RapidData.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            MathLib mathLib = new MathLib(new ListFunctionStrategy());

            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine(mathLib.SquareFactorial(200));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.GetTimeString());

          
            Console.ReadLine();
        }

      
    }
}
