using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class MaxXYTests
    {
        [Test]
        public void MaxXYTest()
        {
            var calc = new MaxXY();
            double first = 31;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(31, result);
        }
    }
}
