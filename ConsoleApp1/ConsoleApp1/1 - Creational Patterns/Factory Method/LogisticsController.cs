namespace ConsoleApp1.CreationalPatterns.FactoryMethod
{
    public sealed class LogisticsController
    {
        private readonly Logistics _logistics;

        public LogisticsController(Logistics logistics)
        {
            _logistics = logistics;
        }

        public void PlanDelivery()
        {
            _logistics.PlanDelivery();
        }
    }
}
