using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(0, 0)]
        [TestCase(35, -0.42818266949615102)]
        [TestCase(90, 0.89399666360055785)]
        public void SinusTest(double first, double expected)
        {
            var calc = new Sinus();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
