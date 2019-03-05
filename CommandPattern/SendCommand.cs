using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class SendCommand : ICommand {
        private Application application;

        public SendCommand(Application application) {
            this.application = application;
        }
        public void Execute() {
            // breaking the 'Law of Demeter!'
            string documentName = application.GetActiveDocument().GetName();

            Console.WriteLine($"Sending {documentName}");
        }
    }
}
