namespace Kalkulator
{
    public class Addition : ITwoArgumentsOperation
    {
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
