using System;

namespace CommandPattern {
    class Program {
        static void Main(string[] args) {
            Application application = new Application();
            ICommand openCommand = new OpenCommand(application);
            ICommand pasteCommand;

            openCommand.Execute();
            pasteCommand = new PasteCommand(application.GetActiveDocument());
            pasteCommand.Execute();

            // will remember the sequence, could also reverse
            MacroCommand macroCommand = new MacroCommand(); 

            // open three documents and send them, later in macroCommand.Execute();
            for (int i = 0; i < 3; i++) {
                macroCommand.Add(new OpenCommand(application));
                macroCommand.Add(new SendCommand(application));
            }

            Console.WriteLine("\r\nCalling macroCommand.Execute()");
            macroCommand.Execute();

            Console.WriteLine("\r\n*****Done*****");

            Console.ReadKey();
        }
    }
}
