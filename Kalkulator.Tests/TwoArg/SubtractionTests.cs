using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class SubtractionTests
    {
        [TestCase(6, 2, 4)]
        [TestCase(2, 4, -2)]
        [TestCase(2, 0, 2)]
        public void SubtractionTest(double first, double second, double expected)
        {
            var calc = new Subtraction();
            double result = calc.Calculate(first, second);
            Assert.AreEqual(expected, result);
        }
    }
    
}
