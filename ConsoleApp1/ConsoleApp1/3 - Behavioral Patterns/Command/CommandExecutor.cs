namespace ConsoleApp1.BehavioralPatterns.Command
{
    public static class CommandExecutor
    {
        public static void Execute()
        {
            string writeText = "Jonas é o melhor";

            Console.WriteLine("Este programa simula um editor de texto...");
            Console.WriteLine($"Texto a ser escrito: '{writeText}'");

            var editor = new Editor();
            var writeCommand = new WriteCommand(writeText, editor);
            var manager = new CommandManager();
            manager.Execute(writeCommand);

            Console.WriteLine($"Texto após ser escrito no editor: '{editor.GetText()}'");
            Console.WriteLine();

            int count = 3;
            Console.WriteLine($"Será removido os {count} últimos caracteres do texto acima");

            var deleteCommand = new DeleteCommand(count, editor);
            manager.Execute(deleteCommand);

            Console.WriteLine($"Texto após a remoção dos caracteres no editor: '{editor.GetText()}'");
            Console.WriteLine();

            string pasteText = "HOR";
            Console.WriteLine($"Texto a ser colado no editor: '{pasteText}'");

            var pasteCommand = new PasteCommand(pasteText, editor);
            manager.Execute(pasteCommand);

            Console.WriteLine($"Texto após a remoção dos caracteres no editor: '{editor.GetText()}'");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Será mostrado agora o Undo dos 3 últimos comandos...");

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Fazendo o {i}º Undo...");
                manager.Undo();
                Console.WriteLine($"Texto após o {i}º Undo: '{editor.GetText()}'");
            }

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Será mostrado agora o Redo em 2 níveis...");

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Fazendo o {i}º Redo...");
                manager.Redo();
                Console.WriteLine($"Texto após o {i}º Redo: '{editor.GetText()}'");
            }
        }
    }
}
