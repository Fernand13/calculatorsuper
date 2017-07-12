using System;

namespace Kalkulator
{
    public class TwoToThePowerX : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(2,first);
        }
    }
}
