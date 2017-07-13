using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class MaxXYTests
    {
        [TestCase(5, 2, 5)]
        [TestCase(6, -2, 6)]
        [TestCase(2, -2, 2)]
        public void MaxXYTest(double first, double second, double expected)
        {
            var calc = new MaxXY();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
