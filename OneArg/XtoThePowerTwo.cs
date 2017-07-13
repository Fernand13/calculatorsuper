using System;

namespace Kalkulator.OneArg
{
    public class XtoThePowerTwo : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,2);
        }
    }
}
