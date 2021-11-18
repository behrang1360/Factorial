using System.Linq;
using System.Numerics;

namespace RapidData.Math
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
            if (!IsInputValid(n)) return 0;
            return _mathLib.Factorial(n);
        }

        public BigInteger UnevenFactorial(int n)
        {
            if (!IsInputValid(n)) return 0;
            return Enumerable.Range(1, n).Where(i => i % 2 == 1).Aggregate(BigInteger.One, (result, element) => result * element);
        }

        public BigInteger SquareFactorial(int n)
        {
            if (!IsInputValid(n)) return 0;
            return Enumerable.Range(1, n).Aggregate(BigInteger.One, (result, element) => result * new BigInteger(System.Math.Pow(element, 2)));
        }

        private bool IsInputValid(int n)
        {
            return n >= 0;
        }
    }
}
