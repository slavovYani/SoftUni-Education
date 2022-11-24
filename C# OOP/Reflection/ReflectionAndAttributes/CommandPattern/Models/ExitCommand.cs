
namespace CommandPattern.Models
{
    using CommandPattern.Core.Contracts;
    using System;

    public class ExitCommand : ICommand
    {
        private const int DEFAULT_ERROR = 0;
        public string Execute(string[] args)
        {
            Environment.Exit(DEFAULT_ERROR);
            return null;
        }
    }
}
