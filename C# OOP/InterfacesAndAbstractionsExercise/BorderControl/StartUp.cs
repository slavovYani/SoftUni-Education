

namespace BorderControl
{
    using BorderControl.Core;
    using IO;
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader,writer);

            
            engine.Run();
        }
    }
}
