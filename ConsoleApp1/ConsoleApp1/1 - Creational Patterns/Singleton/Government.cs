namespace ConsoleApp1.CreationalPatterns.Singleton
{
    public sealed class Government
    {
        private static Government? GovernmentInstance;
        private readonly string _governmentName;
        private readonly List<Authority> _authorities;

        private Government()
        {
            _governmentName = "Governo do Brasil";
            _authorities = new List<Authority>()
            {
                new Authority("Presidente", "Luís Inácio Lula da Silva"),
                new Authority("Governador de São Paulo", "Tarcísio de Freitas"),
                new Authority("Deputado Federal", "Acácio Favacho")
            };
        }

        public static Government GetGovernment()
        {
            if (GovernmentInstance == null)
            {
                GovernmentInstance = new Government();
            }
            
            return GovernmentInstance;
        }

        public void ShowAuthorities()
        {
            Console.WriteLine($"Estes são as seguintes autoridades do {_governmentName}");
            foreach (Authority authority in _authorities)
            {
                Console.WriteLine($"Título: {authority.Title} - Nome: {authority.Name}");
            }
        }
    }
}
