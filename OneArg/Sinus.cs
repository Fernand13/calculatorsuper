using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class Sinus : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Sin(first);
        }
    }
}
