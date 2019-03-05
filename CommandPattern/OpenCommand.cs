using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class OpenCommand : ICommand {
        private Application application;
        private string newDocumentName;

        public OpenCommand(Application application) {
            this.application = application;
        }
        public void Execute() {
            promptForNewDocumentName();
            application.Add(Document.GetNewDocument(newDocumentName));
        }
        private void promptForNewDocumentName() {
            Console.Write("Document name?> ");
            newDocumentName = Console.ReadLine();
        }
    }
}
