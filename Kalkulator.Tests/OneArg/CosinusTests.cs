using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0, 1)]
        [TestCase(90, -0.44807361612917013)]
        [TestCase(180, -0.59846006905785809)]
        public void CosinusTest(double first, double expected)
        {
            var calc = new Cosinus();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
