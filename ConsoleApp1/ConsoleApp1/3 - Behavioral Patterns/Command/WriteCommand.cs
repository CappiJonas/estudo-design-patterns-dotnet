namespace ConsoleApp1.BehavioralPatterns.Command
{
    public sealed class WriteCommand : AbstractCommand, ICommand
    {
        public WriteCommand(string text, Editor editor) : base(text, editor) { }

        public void Execute()
        {
            _editor.Write(_text);
        }
    }
}
