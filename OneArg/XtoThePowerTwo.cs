using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class XtoThePowerTwo : IOneArgumentsOperation
    {
        public double Calculate(double first)
        {
            return Math.Pow(first,2);
        }
    }
}
