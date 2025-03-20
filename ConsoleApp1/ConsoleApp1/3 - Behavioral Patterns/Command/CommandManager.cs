namespace ConsoleApp1.BehavioralPatterns.Command
{
    public sealed class CommandManager
    {
        private Stack<ICommand> undoStack = new Stack<ICommand>();
        private Stack<ICommand> redoStack = new Stack<ICommand>();

        public void Execute(ICommand cmd)
        {
            cmd.Execute();
            undoStack.Push(cmd);
        }

        public void Undo()
        {
            if (undoStack.Count == 0)
            {
                return;
            }

            var command = undoStack.Pop();
            redoStack.Push(command);
            command.Undo();
        }

        public void Redo()
        {
            if (redoStack.Count == 0)
            {
                return;
            }

            var command = redoStack.Pop();
            undoStack.Push(command);
            command.Execute();
        }
    }
}
