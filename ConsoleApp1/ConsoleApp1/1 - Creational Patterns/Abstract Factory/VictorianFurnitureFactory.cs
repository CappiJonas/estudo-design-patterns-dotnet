namespace ConsoleApp1.CreationalPatterns.AbstractFactory
{
    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair() => new VictorianChair();

        public override CoffeeTable CreateCoffeeTable() => new VictorianCoffeeTable();

        public override Sofa CreateSofa() => new VictorianSofa();
    }
}
