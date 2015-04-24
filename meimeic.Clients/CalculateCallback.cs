using System;
using meimeic.Contracts;

namespace meimeic.Clients
{
    class CalculateCallback:ICallBack
    {
        public int Mult(int x, int y)
        {
            Console.WriteLine("开始：执行客户端回调方法-->"+System.DateTime.Now.Ticks);
            int result = x * y;
            Console.WriteLine("完成：执行客户端回调方法-->" + System.DateTime.Now.Ticks);
            return result;
        }
    }
}
