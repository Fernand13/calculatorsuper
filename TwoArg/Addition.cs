namespace Kalkulator.TwoArg
{
    public class Addition : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
