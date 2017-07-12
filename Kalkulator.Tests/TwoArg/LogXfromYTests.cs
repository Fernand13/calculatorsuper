using NUnit.Framework;

namespace Kalkulator.Tests.TwoArg
{
    [TestFixture]
    public class LogXfromYTests
    {
        [Test]
        public void LogXfromYTest()
        {
            var calc = new LogXfromY();
            double first = 6;
            double second = 2;
            double result = calc.Calculate(first, second);
            Assert.AreEqual(3, result);
        }
    }
}