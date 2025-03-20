namespace ConsoleApp1.BehavioralPatterns.Observer
{
    public sealed class MetricObserver : IMetricObserver
    {
        public string Name { get; }

        public MetricObserver(string name)
        {
            Name = name;
        }

        public void Notify(Host host)
        {
            Console.WriteLine($"{Name}: Consumo de cpu está em '{GetSeverity(host.CpuUsage)}' de {host.CpuUsage}% para o host {host.Hostname}.");
            Console.WriteLine($"{Name}: Consumo de memória está em '{GetSeverity(host.MemoryUsage)}' de {host.MemoryUsage}% para o host {host.Hostname}.");
        }

        private string GetSeverity(decimal value)
        {
            return value >= 90 ? "critical" : value >= 85 && value < 90 ? "warning" : "ok";
        }
    }
}
