using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern {
    class MacroCommand : ICommand {
        List<ICommand> commands;
        public MacroCommand() {
            commands = new List<ICommand>();
        }
        public void Add(ICommand command) {
            commands.Add(command);
        }
        public void Remove(ICommand command) {
            commands.Remove(command);
        }
        public void Execute() {
            foreach (ICommand command in commands) {
                command.Execute();
            }
        }
    }
}
