namespace ConsoleApp1.CreationalPatterns.AbstractFactory
{
    public abstract class FurnitureFactory
    {
        public abstract Chair CreateChair();
        public abstract Sofa CreateSofa();
        public abstract CoffeeTable CreateCoffeeTable();
    }
}
