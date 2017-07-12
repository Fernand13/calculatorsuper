using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class CosinusTests
    {
        [Test]
        public void CosinusTest()
        {
            var calc = new Cosinus();
            double first = 0;
            double result = calc.Calculate(first);
            Assert.AreEqual(1, result);
        }
    }
}
