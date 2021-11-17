using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace RapidData.Factorial
{
    public class ListFunctionStrategy : IMathLib
    {
        public BigInteger Factorial(int n) => Enumerable.Range(1, n).Aggregate(BigInteger.One, (result, element) => result * element);
    }
}
