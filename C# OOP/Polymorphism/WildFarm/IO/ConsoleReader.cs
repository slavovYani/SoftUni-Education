
using System;

namespace WildFarm.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
        
    }
}
