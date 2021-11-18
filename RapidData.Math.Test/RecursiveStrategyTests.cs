using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace RapidData.Math.Tests
{
    [TestClass()]
    public class RecursiveStrategyTests
    {
        [DataTestMethod]
        [DataRow(0, "1")]
        [DataRow(5, "120")]
        [DataRow(50, "30414093201713378043612608166064768844377641568960512000000000000")]
        public void Calculate_Factorial_With_RecursiveFunction_Return_BigInterger(int n, string expectetd)
        {
            //Arrange
            var listFunctionStrategy = new ListFunctionStrategy();
            //Act
            var result = listFunctionStrategy.Factorial(n);
            //Assert
            Assert.AreEqual(result, BigInteger.Parse(expectetd));
        }
    }
}