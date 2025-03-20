namespace ConsoleApp1.BehavioralPatterns.Observer
{
    public sealed class Host
    {
        
        private readonly List<IMetricObserver> _metricObservers = new List<IMetricObserver>();

        public decimal CpuUsage { get; private set; }
        public decimal MemoryUsage { get; private set; }
        public string Hostname { get; }

        public Host(string hostname)
        {
            Hostname = hostname;
        }

        public void Subscribe(IMetricObserver observer)
        {
            _metricObservers.Add(observer);
            Console.WriteLine($"Observador de Métrica {observer.Name} adicionado ao monitoramento do host {Hostname}.");
        }

        public void Unsubscribe(IMetricObserver observer)
        {
            _metricObservers.Remove(observer);
            Console.WriteLine($"Observador de Métrica {observer.Name} removido do monitoramento do host {Hostname}.");
        }

        public void SetMetricsValues(decimal cpuUsage, decimal memoryUsage)
        {
            CpuUsage = cpuUsage;
            MemoryUsage = memoryUsage;
            Notify();
        }

        private void Notify()
        {
            foreach (IMetricObserver observer in _metricObservers)
            {
                observer.Notify(this);
            }

            Console.WriteLine();
        }
    }
}
