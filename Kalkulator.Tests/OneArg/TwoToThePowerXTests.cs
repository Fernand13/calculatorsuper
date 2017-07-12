using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class TwoToThePowerXTests
    {
        [Test]
        public void TwoToThePowerXTest()
        {
            var calc = new TwoToThePowerX();
            double first = 2;
            double result = calc.Calculate(first);
            Assert.AreEqual(4, result);
        }
    }
}
