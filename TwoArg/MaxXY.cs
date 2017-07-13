namespace Kalkulator.TwoArg
{/// <summary>
/// Class for Max X and Y function
/// </summary>
    public class MaxXY : ITwoArgumentsOperation
    {       
        /// <summary>
        /// Method forMax X and Y fucntion
        /// </summary>
        /// <param name="first">Input value</param>
        /// <param name="second">exit value</param>
        /// <returns>Calculated value</returns>
        public double Calculate(double first, double second)
        {
            if (first > second) return first;
            else return second;
        }
    }
}
