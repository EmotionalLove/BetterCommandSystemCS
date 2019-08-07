using System;
using System.Collections;
using System.Collections.Generic;

namespace RopeApp
{
    public class CommandProcessor
    {
        public List<Command> CommandRegistry = new List<Command>();
        protected readonly string CommandPrefix;

        public CommandProcessor(string commandPrefix)
        {
            this.CommandPrefix = commandPrefix;
        }

        public void RegisterCommand(Command command)
        {
            CommandRegistry.Add(command);
        }
        
        
    }
}