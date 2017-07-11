using System;

namespace Kalkulator
{
    public static class TwoArgumentsCalculatorsFactory
    {
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
