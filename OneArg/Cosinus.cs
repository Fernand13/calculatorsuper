using System;

namespace Kalkulator.OneArg
{
    public class Cosinus : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
