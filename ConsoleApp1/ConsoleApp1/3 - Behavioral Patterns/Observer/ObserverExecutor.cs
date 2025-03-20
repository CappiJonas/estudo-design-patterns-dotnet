namespace ConsoleApp1.BehavioralPatterns.Observer
{
    public static class ObserverExecutor
    {
        public static void Execute()
        {
            string hostname = string.Empty;
            string metricObserverName = string.Empty;

            do
            {
                Console.WriteLine("Qual o nome do Host que você gostaria de monitorar?");
                Console.Write("Resposta: ");
                hostname = Console.ReadLine()!;
                Console.WriteLine();
                Console.WriteLine($"Qual o nome do Observador das Métricas do Host {hostname}");
                Console.Write("Resposta: ");
                metricObserverName = Console.ReadLine()!;
                Console.WriteLine();

                if (string.IsNullOrEmpty(hostname) || string.IsNullOrEmpty(metricObserverName))
                {
                    Console.WriteLine("O nome do Host e o nome do Observador das Métricas não podem ser nulos nem vazios. Aperte um botão para colocar esses nomes corretamente...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (string.IsNullOrEmpty(hostname) || string.IsNullOrEmpty(metricObserverName));

            var host = new Host(hostname);
            var metricObserver = new MetricObserver(metricObserverName);

            host.Subscribe(metricObserver);

            Console.WriteLine($"Aperte um botão para ver o monitoramento feito pelo {metricObserver.Name} no Host {host.Hostname}...");
            Console.ReadKey();
            Console.WriteLine(); 
            
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(5));
                Console.WriteLine($"Coleta {i}:");
                host.SetMetricsValues(GetMetricValue(), GetMetricValue());
                Console.WriteLine();
            }

            Console.WriteLine($"Aperte um botão para retirar o monitoramento feito pelo {metricObserverName} no Host {host.Hostname}...");
            Console.ReadKey();
            Console.WriteLine();

            host.Unsubscribe(metricObserver);
        }

        private static decimal GetMetricValue()
        {
            var decimals = new decimal[10]
            {
                88.54M, 41.58M, 90.40M, 38.36M, 91.20M, 96.99M, 86.26M, 88.97M, 68.34M, 20.24M
            };
            var index = new Random().Next(0, 9);

            return decimals[index];
        }
    }
}
