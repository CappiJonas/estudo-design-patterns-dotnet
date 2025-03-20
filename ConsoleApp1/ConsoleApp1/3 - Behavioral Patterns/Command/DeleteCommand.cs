namespace ConsoleApp1.BehavioralPatterns.Command
{
    public sealed class DeleteCommand : ICommand
    {
        private readonly int _count;
        private readonly Editor _editor;

        private string _textDeleted = string.Empty;

        public DeleteCommand(int count, Editor editor)
        {
            _count = count;
            _editor = editor;
        }

        public void Execute()
        {
            string text = _editor.GetText();
            _textDeleted = text.Substring(text.Length - _count);
            _editor.Delete(_count);
        }

        public void Undo()
        {
            _editor.Write(_textDeleted);
        }
    }
}
