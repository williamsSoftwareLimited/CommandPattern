using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class PasteCommand : ICommand {
        private Document document;

        public PasteCommand(Document document) {
            this.document = document;
        }
        public void Execute() {
            document.Paste();
        }
    }
}
