using System;

namespace Kalkulator.TwoArg
{
    /// <summary>
    /// Interface for factory
    /// </summary>
    public static class TwoArgumentsCalculatorsFactory
    {
        /// <summary>
        /// Method for factory
        /// </summary>
        /// <param name="first">Input value</param>
        /// <returns>Calculated value</returns>
        public static ITwoArgumentsOperation CreateCalculator (string calculatorName)
        {
            switch (calculatorName)
            {
                case "Sum":
                    return new Addition();
                case "Min":
                    return new Subtraction();
                case "Mul":
                    return new Multiply();
                case "Div":
                    return new Division();
                case "XpowY":
                    return new ХtoThePowerY();
                case "XpowOneDevY":
                    return new Xpow1dY();
                case "LogXfromY":
                    return new LogXfromY();
                case "MinXY":
                    return new MinXY();
                case "MaxXY":
                    return new MaxXY();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
