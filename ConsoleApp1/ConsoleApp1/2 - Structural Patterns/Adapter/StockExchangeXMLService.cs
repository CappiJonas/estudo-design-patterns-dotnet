namespace ConsoleApp1.StructuralPatterns.Adapter
{
    public sealed class StockExchangeXMLService : IStockExchangeXMLService
    {
        public string GetStockExchangeData()
        {
            return "Dados da Bolsa de Valores em XML";
        }
    }
}
