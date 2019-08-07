using System;

namespace RopeApp
{
    public class Command : ICommand
    {
        private string CommandName;

        public Command(string commandName)
        {
            this.CommandName = commandName;
        }

        public void ProcessCommand(bool hasArgs, string[] args)
        {
            ///
        }
    }
}