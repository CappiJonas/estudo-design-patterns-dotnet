namespace ConsoleApp1.BehavioralPatterns.Observer
{
    public interface IMetricObserver
    {
        string Name { get; }
        void Notify(Host host);
    }
}
