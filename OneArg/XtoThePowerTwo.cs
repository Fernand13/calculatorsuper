using System;

namespace Kalkulator.OneArg
{/// <summary>
/// Class for X to The Power Two function
/// </summary>
    public class XtoThePowerTwo : IOneArgumentsOperation
    {
        /// <summary>
        /// Method for X to The Power Two fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first)
        {
            return Math.Pow(first,2);
        }
    }
}
