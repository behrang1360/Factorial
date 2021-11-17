using System;
using System.Linq;
using System.Numerics;

namespace RapidData.Factorial
{
    public class MathLib
    {
        private IMathLib _mathLib;
        public MathLib(IMathLib mathLib)
        {
            SetStrategy(mathLib);
        }

        private void SetStrategy(IMathLib mathLib)
        {
            _mathLib = mathLib;
        }

        public BigInteger Factorial(int n)
        {
            if (n < 0) return 0;
            return _mathLib.Factorial(n);
        }

        public BigInteger UnevenFactorial(int n) => Enumerable.Range(1, n).Where(i => i % 2 == 1)
            .Aggregate(BigInteger.One, (result, element) => result * element);

        public BigInteger SquareFactorial(int n) => Enumerable.Range(1, n)
             .Aggregate(BigInteger.One, (result, element) => result * new BigInteger(Math.Pow(element, 2)));
    }
}
