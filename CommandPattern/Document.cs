using System;

namespace CommandPattern {
    class Document {
        private string name;
        private Document(string name) {
            this.name = name;
        }
        public string GetName() {
            return this.name;
        }
        public static Document GetNewDocument(string newDocumentName) {
            Console.WriteLine($"Creating and returning document named {newDocumentName}.");

            return new Document(newDocumentName);
        }

        internal void Paste() {
            Console.WriteLine($"Pasting document named {name}.");
        }
    }
}