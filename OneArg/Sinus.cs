using System;

namespace Kalkulator.OneArg
{
    public class Sinus : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
