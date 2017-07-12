using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class TangensTests
    {
        [Test]
        public void TangensTest()
        {
            var calc = new Tangens();
            double first = 0;
            double result = calc.Calculate(first);
            Assert.AreEqual(0, result);
        }
    }
}
