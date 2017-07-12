using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test] public void MulyiplyTest()
        {
            var calc = new Multiply();
            double first = 2;
            double second = 3;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(6, result);
        }
    }
}
