namespace ConsoleApp1.CreationalPatterns.Singleton
{
    public static class SingletonExecutor
    {
        public static void Execute()
        {
            var governmentA = Government.GetGovernment();
            var governmentB = Government.GetGovernment();

            if (governmentA == governmentB)
            {
                Console.WriteLine("Mesma instância de governos!!!!!!");
                Console.WriteLine();
            }

            var government = Government.GetGovernment();
            government.ShowAuthorities();
        }
    }
}
