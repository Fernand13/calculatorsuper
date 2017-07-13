using System;

namespace Kalkulator.OneArg
{
    public class Tangens : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
