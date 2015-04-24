using System.ServiceModel;

namespace meimeic.Contracts
{
    public interface ICallBack
    {
        [OperationContract]
        int Mult(int x,int y);
    }
}
