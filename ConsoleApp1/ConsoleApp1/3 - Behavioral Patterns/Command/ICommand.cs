namespace ConsoleApp1.BehavioralPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
