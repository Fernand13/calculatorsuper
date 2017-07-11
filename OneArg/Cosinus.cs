using System;

namespace Kalkulator
{
    public class Cosinus : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Cos(first);
        }
    }
}
