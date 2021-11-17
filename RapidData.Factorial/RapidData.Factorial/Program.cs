using System;

namespace RapidData.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MathLib mathLib = new MathLib(new ListFunctionStrategy());          
            Console.WriteLine(mathLib.SquareFactorial(200));                    
            Console.ReadLine();
        }
    }
}
