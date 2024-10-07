using CoreWCF;

namespace CoreWcfHttpService
{
    public class CalculatorService : ICalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}