namespace ConsoleApp1.CreationalPatterns.AbstractFactory
{
    public class ArtDecoFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair() => new ArtDecoChair();

        public override CoffeeTable CreateCoffeeTable() => new ArtDecoCoffeeTable();

        public override Sofa CreateSofa() => new ArtDecoSofa();
    }
}
