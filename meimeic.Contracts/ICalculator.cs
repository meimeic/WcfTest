using System.ServiceModel;

namespace meimeic.Contracts
{
    [ServiceContract(Namespace = "http://www.meimeic.com/", CallbackContract = typeof(ICallBack))]
    public interface ICalculator
    {
        [OperationContract]
        int Add(int x, int y);
    }
}
