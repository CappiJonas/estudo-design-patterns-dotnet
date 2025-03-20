namespace ConsoleApp1.BehavioralPatterns.Command
{
    public sealed class Editor
    {
        private string _textBuffer = string.Empty;

        public void Write(string text)
        {
            _textBuffer += text;
        }

        public void Delete(int count)
        {
            _textBuffer = _textBuffer.Substring(0, _textBuffer.Length - Math.Min(count, _textBuffer.Length));
        }

        public void Paste(string text)
        {
            Write(text);
        }

        public string GetText()
        {
            return _textBuffer;
        }
    }
}
