using ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies.Interfaces;

namespace ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies
{
    public sealed class PublicTransportStrategy : IRouteStrategy
    {
        public void BuildRoute()
        {
            Console.WriteLine("Rota de transporte público do ponto A ao ponto B planejada.");
        }
    }
}
