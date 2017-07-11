using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
