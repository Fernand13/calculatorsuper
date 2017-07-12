using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class SubtractionTests
    {
        [Test]
        public void SubtractionTest()
        {
            var calc = new Subtraction();
            double first = 4;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(2, result);
        }
    }
}
