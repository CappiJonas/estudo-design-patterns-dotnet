namespace ConsoleApp1.BehavioralPatterns.Command
{
    public abstract class AbstractCommand
    {
        protected readonly string _text;
        protected readonly Editor _editor;

        protected AbstractCommand(string text, Editor editor)
        {
            _text = text;
            _editor = editor;
        }

        public void Undo()
        {
            _editor.Delete(_text.Length);
        }
    }
}
