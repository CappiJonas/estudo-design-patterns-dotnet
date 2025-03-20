namespace ConsoleApp1.StructuralPatterns.Adapter
{
    public sealed class StockExchangeAdapter : IStockExchangeXMLService
    {
        private readonly IStockExchangeJSONService _stockExchangeJSONService;

        public StockExchangeAdapter(IStockExchangeJSONService stockExchangeJSONService)
        {
            _stockExchangeJSONService = stockExchangeJSONService;
        }

        public string GetStockExchangeData()
        {
            return _stockExchangeJSONService.GetStockExchangeData();
        }
    }
}
