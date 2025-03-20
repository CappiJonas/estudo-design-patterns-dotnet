namespace ConsoleApp1.CreationalPatterns.AbstractFactory
{
    public sealed class AbstractFactoryController 
    {
        private readonly FurnitureFactory _factory;

        public AbstractFactoryController(FurnitureFactory factory)
        {
            _factory = factory;
        }

        public void CreateFurniture()
        {
            var chair = _factory.CreateChair();
            var sofa = _factory.CreateSofa();
            var coffeTable = _factory.CreateCoffeeTable();

            Console.WriteLine("Seguintes móveis criados:");
            Console.WriteLine(chair.ToString());
            Console.WriteLine(sofa.ToString());
            Console.WriteLine(coffeTable.ToString());
        }
    }
}
