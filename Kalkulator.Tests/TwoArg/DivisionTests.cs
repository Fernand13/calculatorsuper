using System;
using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(2,2,1)]
        [TestCase(2,4,0.5)]
        [TestCase(2,-2,-1)]
        public void DivisionTest(double first, double second, double expected)
        {
            var calc = new Division();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivisionByZeroTest()
        {
            var calc = new Division();
            Assert.Throws<Exception>(() => calc.Calculate(1, 0));
        }
    }

}