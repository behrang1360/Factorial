using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace RapidData.Math.Tests
{
    [TestClass()]
    public class MathLibTests
    {
        [DataTestMethod]
        [DataRow(0, "1")]
        [DataRow(5, "15")]
        [DataRow(8, "105")]
        [DataRow(50, "58435841445947272053455474390625")]
        public void Calculate_Factorial_For_Odd_Number_Return_BigInterger(int n, string expectetd)
        {
            //Arrange
            var mathLib = new MathLib(new RecursiveStrategy());
            //Act
            var result = mathLib.UnevenFactorial(n);
            //Assert
            Assert.AreEqual(result, BigInteger.Parse(expectetd));
        }

        [DataTestMethod]
        [DataRow(0, "1")]
        [DataRow(3, "36")]
        [DataRow(5, "14400")]
        [DataRow(50, "925017065282507919013470723235883682349486807421901987706139271018810570717360434442383213140448215302144000000000000000000000000")]
        public void Calculate_Factorial_With_Squaring_Number_Return_BigInterger(int n, string expectetd)
        {
            //Arrange
            var mathLib = new MathLib(new RecursiveStrategy());
            //Act
            var result = mathLib.SquareFactorial(n);
            //Assert
            Assert.AreEqual(result, BigInteger.Parse(expectetd));
        }
    }
}