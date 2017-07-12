using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class MinXYTests
    {
        [Test]
        public void MinXYTest()
        {
            var calc = new MinXY();
            double first = 31;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(2, result);
        }
    }
}
