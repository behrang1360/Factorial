using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RapidData.Factorial
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
