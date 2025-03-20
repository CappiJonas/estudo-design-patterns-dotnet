namespace ConsoleApp1.StructuralPatterns.Adapter
{
    public static class AdapterExecutor
    {
        public static void Execute()
        {
            var xmlController = new StockExchangeController(new StockExchangeXMLService());
            xmlController.GetStockExchangeData();

            var jsonAdapteeController = new StockExchangeController(new StockExchangeAdapter(new StockExchangeJSONService()));
            jsonAdapteeController.GetStockExchangeData();
        }
    }
}
