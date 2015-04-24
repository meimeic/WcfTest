using System;
using System.ServiceModel;
using meimeic.Contracts;

namespace meimeic.Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext instanceContext = new InstanceContext(new CalculateCallback());
            using (DuplexChannelFactory<ICalculator> channelFactory = new DuplexChannelFactory<ICalculator>(instanceContext, "CalculatorService"))
            {
                ICalculator proxy = channelFactory.CreateChannel();
                using (proxy as IDisposable) {
                    Console.WriteLine("开始：调用服务端方法-->"+System.DateTime.Now.Ticks);
                    int result=proxy.Add(1, 2);
                    Console.WriteLine("结束：调用服务端方法-->" + System.DateTime.Now.Ticks);
                    Console.WriteLine("service add result is {0}",result);
                    Console.Read();
                }
            }
        }
    }
}
