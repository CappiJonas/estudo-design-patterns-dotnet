namespace ConsoleApp1.CreationalPatterns.FactoryMethod
{
    public sealed class RoadLogistics : Logistics
    {
        public override Transport CreateLogistics() => new Truck();
    }
}
