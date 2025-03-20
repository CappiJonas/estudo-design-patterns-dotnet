namespace ConsoleApp1.StructuralPatterns.Adapter
{
    public sealed class StockExchangeJSONService : IStockExchangeJSONService
    {
        public string GetStockExchangeData()
        {
            return "Dados da Bolsa de Valores em JSON";
        }
    }
}
