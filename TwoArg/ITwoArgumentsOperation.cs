using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
     public interface ITwoArgumentsOperation
    {
        double Calculate(double first, double second);
    }
}
