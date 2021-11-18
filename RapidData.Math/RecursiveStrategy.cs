using System.Numerics;

namespace RapidData.Math
{
    public class RecursiveStrategy : IMathLib
    {
        public BigInteger Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}
