using ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies.Interfaces;

namespace ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies
{
    public sealed class WalkingStrategy : IRouteStrategy
    {
        public void BuildRoute()
        {
            Console.WriteLine("Rota a pé do ponto A ao ponto B planejada.");
        }
    }
}
