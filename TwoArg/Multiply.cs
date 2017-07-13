namespace Kalkulator.TwoArg
{
    public class Multiply : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return first * second;
        }
    }
}
