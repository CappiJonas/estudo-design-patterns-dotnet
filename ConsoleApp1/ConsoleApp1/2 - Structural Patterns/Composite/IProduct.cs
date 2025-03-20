namespace ConsoleApp1.StructuralPatterns.Composite
{
    public interface IProduct
    {
        string Name { get; }
        decimal Price { get; }

        decimal CalculateTotalPrice();
        void OpenProducts(int sub);
    }
}
