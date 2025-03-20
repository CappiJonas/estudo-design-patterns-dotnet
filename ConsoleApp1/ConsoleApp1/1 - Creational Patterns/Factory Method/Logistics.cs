namespace ConsoleApp1.CreationalPatterns.FactoryMethod
{
    public abstract class Logistics
    {
        public abstract Transport CreateLogistics();

        public void PlanDelivery()
        {
            Transport transport = CreateLogistics();
            Console.WriteLine($"Transporte será feito através de {transport.Deliver()}");
        }
    }
}
