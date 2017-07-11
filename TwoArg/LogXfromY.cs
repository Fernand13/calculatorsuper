using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class LogXfromY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first,second);
        }
    }
}
