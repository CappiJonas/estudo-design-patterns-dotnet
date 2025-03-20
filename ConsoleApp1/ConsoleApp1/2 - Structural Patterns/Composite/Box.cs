using System.Collections;

namespace ConsoleApp1.StructuralPatterns.Composite
{
    public sealed class Box : IProduct, IEnumerable<IProduct>
    {
        private readonly List<IProduct> _products = new List<IProduct>();

        public string Name { get; } = string.Empty;
        public decimal Price { get; private set; }

        public Box(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public IEnumerator<IProduct> GetEnumerator()
        {
            return _products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _products.GetEnumerator();
        }

        public void AddProduct(IProduct product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            _products.Remove(product);
        }

        public IEnumerable<IProduct> GetProducts()
        {
            return _products;
        }

        public void OpenProducts(int sub)
        {
            Console.WriteLine($"{new string('-', sub)} Abrindo {Name}");

            foreach (IProduct product in _products)
            {
                product.OpenProducts(sub + sub);
            }
        }

        public decimal CalculateTotalPrice()
        {
            foreach (IProduct product in _products)
            {
                Price += product.CalculateTotalPrice();
            }

            return Price;
        }
    }
}
