using System;
using System.ServiceModel;

namespace EssentialWCF
{
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        double GetPrice(string ticker);
    }

    public class StockService : IStockService
    {
        public double GetPrice(string ticker)
        {
            return 94.85;
        }
    }

    class Service
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(StockService));
            serviceHost.Open();

            Console.WriteLine("Для завершения нажмите <ENTER>.\n\n");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
