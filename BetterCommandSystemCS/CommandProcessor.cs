using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        public bool ProcessCommand(string str)
        {
            str = str.Trim(); // YES IM REASSIGNING A PARAMETER DEAL WITH IT :<
            if (!str.StartsWith(CommandPrefix))
                throw new ArgumentException("Input doesn't begin with the set command prefix.");
            if (!str.Contains(" "))
            {
                // no args
                foreach (var command in CommandRegistry)
                {
                    if (!(CommandPrefix + command.GetCommandName()).ToLower().Equals(str.ToLower())) continue;
                    command.ProcessCommand(false, new string[0]);
                    return true;
                }

                return false;
            }

            // has args
            List<string> args = new List<string>(str.Split(" "));
            var cmd = args[0].ToLower();
            args.RemoveAt(0);
            foreach (var command in CommandRegistry)
            {
                if (!(CommandPrefix + command.GetCommandName()).ToLower().Equals(cmd)) continue;
                command.ProcessCommand(true, args.ToArray());
                return true;
            }

            return false;
        }
    }
}