using ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies.Interfaces;

namespace ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies
{
    public sealed class RoadStrategy : IRouteStrategy
    {
        public void BuildRoute()
        {
            Console.WriteLine("Rota rodoviária do ponto A ao ponto B planejada.");
        }
    }
}
