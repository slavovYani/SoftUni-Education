
namespace CommandPattern.Core
{
    using CommandPattern.IO;
    using CommandPattern.IO.Interfaces;
    using Contracts;
    using System;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter) : this()
        {
            this.commandInterpreter = commandInterpreter;
        }
        private Engine()
        {
            this.reader = new ConsoleReader();
            this.writer = new ConsoleWriter();

        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = this.reader.ReadLine();
                    string result = this.commandInterpreter.Read(input);
                    this.writer.WriteLine(result);
                }
                catch (InvalidOperationException ioe)
                {

                    this.writer.WriteLine(ioe.Message);
                }
            }
        }
    }
}
