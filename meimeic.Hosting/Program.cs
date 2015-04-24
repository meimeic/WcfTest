using System;
using System.ServiceModel;
using meimeic.Services;

namespace meimeic.Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Open();
                Console.Read();
            }
        }
    }
}
