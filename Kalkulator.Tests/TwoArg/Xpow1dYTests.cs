using Kalkulator.TwoArg;
using System;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class Xpow1dYTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(4, 2, 2)]
        [TestCase(4, -2, 0.5)]
        public void Xpow1dYTest(double first, double second, double expected)
        {
            var calc = new Xpow1dY();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Xpow1dYByZeroTest()
        {
            var calc = new Xpow1dY();
            Assert.Throws<Exception>(() => calc.Calculate(1, 0));
        }
    }
}
