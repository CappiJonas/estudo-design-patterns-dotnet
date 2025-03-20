namespace ConsoleApp1.CreationalPatterns.FactoryMethod
{
    public sealed class SeaLogistics : Logistics
    {
        public override Transport CreateLogistics() => new Ship();
    }
}
