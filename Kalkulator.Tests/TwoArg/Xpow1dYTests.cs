using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class Xpow1dYTests
    {
        [Test]
        public void Xpow1dYTest()
        {
            var calc = new Xpow1dY();
            double first = 4;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(2, result);
        }
    }
}
