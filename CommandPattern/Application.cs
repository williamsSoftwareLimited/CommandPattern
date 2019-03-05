using System;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern {
    public class Application {

        List<Document> documents;

        public Application() {
            documents = new List<Document>();
        }

        internal void Add(Document document) {
            documents.Add(document);
            Console.WriteLine($"Adding document with name {document.GetName()} to Application.");
        } 
        internal Document GetActiveDocument() {
            return documents[documents.Count-1];
        }
        
    }
}