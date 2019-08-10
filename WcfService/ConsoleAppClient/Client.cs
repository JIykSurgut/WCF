using System;
using System.ServiceModel;

namespace ConsoleAppClient
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        double GetPrice(string ticker);
    }

    class Client
    {
        static void Main(string[] args)
        {
            ChannelFactory<IStockService> myChannelFactory =
                new ChannelFactory<IStockService>(new BasicHttpBinding(), new EndpointAddress("http://localhost:8000/EssentialWCF"));

            IStockService wcfClient = myChannelFactory.CreateChannel();

            double p = wcfClient.GetPrice("msft");
            Console.WriteLine("Price:{0}",p);
        }
    }
}
