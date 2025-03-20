namespace ConsoleApp1.StructuralPatterns.Composite
{
    public sealed class Product : IProduct
    {
        public string Name { get; } = string.Empty;
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public decimal CalculateTotalPrice()
        {
            return Price;
        }

        public void OpenProducts(int sub)
        {
            Console.WriteLine($"{new string('-', sub)} Produto aberto: {Name}");
        }
    }
}
