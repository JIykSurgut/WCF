using System;
using System.ServiceModel;

namespace WcfService
{
    [Serializable]
    public class PriceDetails
    {
        public string Ticker;
        public double Amount;
    }

    [MessageContract]
    public class StockPrice
    {
        [MessageHeader]
        public DateTime CurrentTime;

        [MessageBodyMember]
        public PriceDetails Price;
    }

    //[MessageContract]
    //public class StockPriceReq
    //{
    //    [MessageBodyMember]
    //    public string Ticker;
    //}

    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        StockPrice GetPrice(string req);//(StockPriceReq req);
    }
}
