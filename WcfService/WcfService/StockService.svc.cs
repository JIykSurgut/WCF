namespace WcfService
{
    public class StockService : IStockService
    {
        public StockPrice GetPrice(string req)
        {
            StockPrice resp = new StockPrice();
            resp.Price = new PriceDetails();
            resp.Price.Ticker = req;
            resp.Price.Amount = 94.85;
            return resp;
        }
    }
}
