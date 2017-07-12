using System;

namespace Kalkulator
{
    public class Tangens : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Tan(first);
        }
    }
}
