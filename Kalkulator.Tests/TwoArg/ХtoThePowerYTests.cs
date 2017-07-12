using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class ХtoThePowerYTests
    {
        [Test]
        public void ХtoThePowerYTest()
        {
            var calc = new ХtoThePowerY();
            double first = 2;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(4, result);
        }
    }
}
