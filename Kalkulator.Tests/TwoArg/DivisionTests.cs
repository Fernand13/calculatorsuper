using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void DivisionTest()
        {
            var calc = new Division();
            double first = 6;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(3, result);
        }
    }
}