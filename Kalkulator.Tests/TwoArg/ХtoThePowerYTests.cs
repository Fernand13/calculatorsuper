using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class ХtoThePowerYTests
    {
        [TestCase(4, 2, 16)]
        [TestCase(0, 5, 0)]
        [TestCase(2, 0, 1)]
        public void ХtoThePowerYTest(double first, double second, double expected)
        {
            var calc = new ХtoThePowerY();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
