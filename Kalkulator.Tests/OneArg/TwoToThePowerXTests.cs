using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class TwoToThePowerXTests
    {
        [TestCase(4, 16)]
        [TestCase(-2, 0.25)]
        [TestCase(1, 2)]
        public void TwoToThePowerXTest(double first, double expected)
        {
            var calc = new TwoToThePowerX();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
