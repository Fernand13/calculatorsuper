using System;

namespace Kalkulator.TwoArg
{
    public class Xpow1dY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return Math.Pow(first, 1/second);
        }
    }
}
