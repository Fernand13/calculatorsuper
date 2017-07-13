using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class AdditionTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 4, 6)]
        [TestCase(2, -2, 0)]
        public void AdditionTest(double first, double second, double expected)
        {
            var calc = new Addition();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
}
