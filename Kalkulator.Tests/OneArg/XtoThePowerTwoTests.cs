using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class XtoThePowerTwoTests
    {
        [TestCase(2, 4)]
        [TestCase(-3, 9)]
        [TestCase(0, 0)]
        public void XtoThePowerTwoTest(double first, double expected)
        {
            var calc = new XtoThePowerTwo();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
