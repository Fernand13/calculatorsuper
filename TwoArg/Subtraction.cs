namespace Kalkulator.TwoArg
{/// <summary>
/// Class for Subtraction function
/// </summary>
    public class Subtraction : ITwoArgumentsOperation
    {
        /// <summary>
        /// Method for Subtraction fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">exit value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}