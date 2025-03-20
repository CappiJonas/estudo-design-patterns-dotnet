namespace ConsoleApp1.CreationalPatterns.AbstractFactory
{
    internal class ColonialFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair() => new ColonialChair();

        public override CoffeeTable CreateCoffeeTable() => new ColonialCoffeeTable();

        public override Sofa CreateSofa() => new ColonialSofa();
    }
}
