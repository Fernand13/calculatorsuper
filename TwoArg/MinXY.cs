using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class MinXY : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            if (first > second) return first;
            else return second;
        }
    }
}
