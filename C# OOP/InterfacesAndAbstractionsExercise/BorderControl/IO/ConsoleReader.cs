
namespace BorderControl.IO
{
    using System;
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();

    }
}
