namespace ConsoleApp1.CreationalPatterns.Singleton
{
    public sealed class Authority
    {
        public string Title { get; }
        public string Name { get; }

        public Authority(string title, string name)
        {
            Title = title;
            Name = name;
        }
    }
}
