using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public interface IOneArgumentsOperation
    {
        double Calculate(double first);
    }
}
