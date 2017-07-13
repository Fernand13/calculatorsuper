using System;

namespace Kalkulator.TwoArg
{
    public class ХtoThePowerY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first,second);
        }
    }
}
