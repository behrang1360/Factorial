using System.Linq;
using System.Numerics;

namespace RapidData.Math
{
    public class ListFunctionStrategy : IMathLib
    {
        public BigInteger Factorial(int n) => Enumerable.Range(1, n).Aggregate(BigInteger.One, (result, element) => result * element);
    }
}
