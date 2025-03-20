using ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies.Interfaces;

namespace ConsoleApp1.BehavioralPatterns.Strategy
{
    public sealed class RouteController
    {
        private readonly IRouteStrategy _strategy;

        public RouteController(IRouteStrategy strategy)
        {
            _strategy = strategy;
        }

        public void BuildRoute()
        {
            _strategy.BuildRoute();
        }
    }
}
