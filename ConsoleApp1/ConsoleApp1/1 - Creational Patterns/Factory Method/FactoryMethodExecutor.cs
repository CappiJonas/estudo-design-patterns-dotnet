namespace ConsoleApp1.CreationalPatterns.FactoryMethod
{
    public static class FactoryMethodExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("Qual transporte será utilizado para a entrega?");
            Console.WriteLine("1 - Caminhão, 2 - Navio");
            Console.Write("Resposta: ");
            string answer = Console.ReadLine()!;
            LogisticsController? controller = null;

            switch (answer) 
            {
                case "1":
                    controller = new LogisticsController(new RoadLogistics());
                    break;
                case "2":
                    controller = new LogisticsController(new SeaLogistics());
                    break;
            }

            controller!.PlanDelivery();
        }
    }
}
