using Kalkulator.TwoArg;
using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void AdditionTest()
        {
            var calc=new Addition();
            double first = 2;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(4,result);
        }
    }
}
