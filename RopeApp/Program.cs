using System;

namespace RopeApp
{
    class Program
    {
        
        private static CommandProcessor _commandProcessor = new CommandProcessor("!");
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            _commandProcessor.RegisterCommand(new HelloCommand());
            if (!_commandProcessor.ProcessCommand("!screm"))
            {
                Console.Write("Baka");
            }
        }
    }

    class HelloCommand : Command
    {
        public HelloCommand() : base("screm")
        {
        }

        public override void ProcessCommand(bool hasArgs, string[] args)
        {
            Console.WriteLine(":screm:");
        }
    }
}