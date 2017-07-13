using System;
using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class LogXfromYTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(2, 4, 0.5)]
        [TestCase(2, 8, 0.33333333333333337)]
        public void LogXfromYTest(double first, double second, double expected)
        {
            var calc = new LogXfromY();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void LogXfromYByZeroTest()
        {
            var calc = new LogXfromY();
            Assert.Throws<Exception>(() => calc.Calculate(0, 2));
        }
    }

}