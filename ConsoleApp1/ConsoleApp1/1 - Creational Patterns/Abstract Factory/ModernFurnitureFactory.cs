namespace ConsoleApp1.CreationalPatterns.AbstractFactory
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair() => new ModernChair();

        public override CoffeeTable CreateCoffeeTable() => new ModernCoffeeTable();

        public override Sofa CreateSofa() => new ModernSofa();
    }
}
