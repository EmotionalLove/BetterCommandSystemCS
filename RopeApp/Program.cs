using System;
using System.Text;

namespace RopeApp
{
    class Program
    {
        
        private static CommandProcessor _commandProcessor = new CommandProcessor("!");
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            _commandProcessor.RegisterCommand(new HelloCommand());
            if (!_commandProcessor.ProcessCommand("!screm rope me to the hole"))
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
            if (!hasArgs) Console.WriteLine(":screm:");
            else
            {
                StringBuilder builder = new StringBuilder();
                foreach (var s in args)
                {
                    builder.Append(s.Replace("o", "owo") + " ");
                }
                Console.WriteLine(builder.ToString());
            }
        }
    }
}