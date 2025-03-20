namespace ConsoleApp1.StructuralPatterns.Composite
{
    public static class CompositeExecutor
    {
        public static void Execute()
        {
            var necklace = new Product("Colar", 5);
            var ring = new Product("Anel", 7);
            var tinyBox = new Box("Caixa Minúscula", 1);
            tinyBox.AddProduct(necklace);
            tinyBox.AddProduct(ring);

            var cellphone = new Product("Celular", 20);
            var smallBox1 = new Box("Caixa Pequena 1", 2);
            smallBox1.AddProduct(cellphone);
            smallBox1.AddProduct(tinyBox);

            var glasses = new Product("Óculos", 15);
            var smallBox2 = new Box("Caixa Pequena 2", 2);
            smallBox2.AddProduct(glasses);

            var mediumBox = new Box("Caixa média", 3);
            var pan = new Product("Panela", 60);
            mediumBox.AddProduct(smallBox1);
            mediumBox.AddProduct(smallBox2);
            mediumBox.AddProduct(pan);

            var microwave = new Product("Micro-ondas", 150);
            var bigBox = new Box("Caixa Grande", 5);
            bigBox.AddProduct(microwave);
            bigBox.AddProduct(mediumBox);

            bigBox.OpenProducts(2);

            decimal totalPrice = bigBox.CalculateTotalPrice();
            Console.WriteLine($"Preço Total: {totalPrice}");
        }
    }
}
