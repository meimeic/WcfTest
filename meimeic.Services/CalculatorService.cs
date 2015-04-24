using System;
using System.ServiceModel;
using meimeic.Contracts;

namespace meimeic.Services
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class CalculatorService:ICalculator
    {
        public int Add(int x, int y)
        {
            Console.WriteLine("开始：执行服务端方法-->" + System.DateTime.Now.Ticks);
            ICallBack callback = OperationContext.Current.GetCallbackChannel<ICallBack>();
            Console.WriteLine("开始：回调客户端方法-->" + System.DateTime.Now.Ticks);
            int temp = callback.Mult(x, y);
            Console.WriteLine("完成：回调客户端方法-->" + System.DateTime.Now.Ticks);
            Console.WriteLine("client callback result is {0}", temp);
            int result = temp + (y - x);
            Console.WriteLine("完成：执行服务端方法-->" + System.DateTime.Now.Ticks);
            return result;
        }
    }
}
