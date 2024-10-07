using CoreWCF;

namespace CoreWcfHttpService
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int a, int b);
    }
}