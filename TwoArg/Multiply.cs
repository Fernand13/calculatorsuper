namespace Kalkulator.TwoArg
{/// <summary>
/// Class for Multiply function
/// </summary>
    public class Multiply : ITwoArgumentsOperation
    {
        /// <summary>
        /// Method for Multiply fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">exit value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
