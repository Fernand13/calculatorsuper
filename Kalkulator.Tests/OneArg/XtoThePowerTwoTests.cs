using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class XtoThePowerTwoTests
    {
        [Test]
        public void XtoThePowerTwoTest()
        {
            var calc = new XtoThePowerTwo();
            double first = 2;
            double result = calc.Calculate(first);
            Assert.AreEqual(4, result);
        }
    }
}
