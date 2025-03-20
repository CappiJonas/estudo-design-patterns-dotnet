namespace ConsoleApp1.BehavioralPatterns.Command
{
    public sealed class PasteCommand : AbstractCommand, ICommand
    {
        public PasteCommand(string text, Editor editor) : base(text, editor) { }

        public void Execute()
        {
            _editor.Paste(_text);
        }
    }
}
