using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class SinusTests
    {
        [Test]
        public void SinusTest()
        {
            var calc = new Sinus();
            double first = 0;
            double result = calc.Calculate(first);
            Assert.AreEqual(0, result);
        }
    }
}
