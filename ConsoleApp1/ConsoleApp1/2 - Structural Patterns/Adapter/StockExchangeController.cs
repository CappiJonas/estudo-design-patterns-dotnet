namespace ConsoleApp1.StructuralPatterns.Adapter
{
    public sealed class StockExchangeController
    {
        private readonly IStockExchangeXMLService _service;

        public StockExchangeController(IStockExchangeXMLService service)
        {
            _service = service;
        }

        public void GetStockExchangeData()
        {
            string data = _service.GetStockExchangeData();
            Console.WriteLine($"Dados da Bolsa de Valores - {data}");
        }
    }
}
