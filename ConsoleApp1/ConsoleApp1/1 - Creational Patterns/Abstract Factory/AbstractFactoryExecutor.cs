namespace ConsoleApp1.CreationalPatterns.AbstractFactory
{
    public static class AbstractFactoryExecutor
    {
        public static void Execute()
        {
            Console.WriteLine("Qual estilo de movéis você quer?");
            Console.WriteLine("1 - Arte Decoração, 2 - Vitoriana, 3 - Moderna, 4 - Colonial");
            Console.Write("Resposta: ");
            Style style = (Style)Enum.Parse(typeof(Style), Console.ReadLine()!);
            AbstractFactoryController? controller = null;

            switch (style)
            {
                case Style.ArtDeco:
                    controller = new AbstractFactoryController(new ArtDecoFurnitureFactory());
                    break;
                case Style.Victorian:
                    controller = new AbstractFactoryController(new VictorianFurnitureFactory());
                    break;
                case Style.Modern:
                    controller = new AbstractFactoryController(new ModernFurnitureFactory());
                    break;
                case Style.Colonial:
                    controller = new AbstractFactoryController(new ColonialFurnitureFactory());
                    break;
            }

            controller!.CreateFurniture();
        }
    }
}
