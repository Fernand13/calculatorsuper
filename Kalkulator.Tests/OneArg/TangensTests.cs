using Kalkulator.OneArg;
using NUnit.Framework;

namespace Kalkulator.Tests.OneArg
{
    [TestFixture]
    public class TangensTests
    {
        [TestCase(0,0)]
        [TestCase(45, 1.6197751905438615)]
        [TestCase(135, -0.088715756770060453)]
        public void TangensTest(double first, double expected)
        {
            var calc = new Tangens();
            double result = calc.Calculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
