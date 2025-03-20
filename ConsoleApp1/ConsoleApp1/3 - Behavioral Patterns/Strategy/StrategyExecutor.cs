using ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies;
using ConsoleApp1.BehavioralPatterns.Strategy.RouteStrategies.Interfaces;

namespace ConsoleApp1.BehavioralPatterns.Strategy
{
    public static class StrategyExecutor
    {
        public static void Execute()
        {
            bool shouldRepeat = false;
            int option;
            IRouteStrategy? strategy = null;

            do
            {
                Console.WriteLine("Qual o tipo de rota gostaria de planejar sua viagem?");
                Console.WriteLine("1 - Rota rodoviária; 2 - Rota a pé; 3 - Rota de transporte público");
                Console.Write("Resposta: ");
                string answer = Console.ReadLine()!;
                shouldRepeat = !(int.TryParse(answer, out option) && (option >= 1 && option <= 3));

                if (shouldRepeat)
                {
                    Console.WriteLine("Opção errada escolhida. Aperte um botão para escolher novamente...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (shouldRepeat);
            
            switch (option) 
            {
                case 1:
                    strategy = new RoadStrategy();
                    break;
                case 2:
                    strategy = new WalkingStrategy();
                    break;
                case 3:
                    strategy = new PublicTransportStrategy();
                    break;
            }

            var controller = new RouteController(strategy!);
            controller.BuildRoute();
        }
    }
}
