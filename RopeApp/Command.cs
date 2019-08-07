using System;

namespace RopeApp
{
    public abstract class Command : ICommand
    {
        private readonly string _commandName;

        public Command(string commandName)
        {
            this._commandName = commandName;
        }

        public abstract void ProcessCommand(bool hasArgs, string[] args);
        public string GetCommandName()
        {
            return _commandName;
        }
    }
}