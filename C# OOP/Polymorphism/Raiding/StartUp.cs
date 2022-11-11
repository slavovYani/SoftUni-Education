
using Raiding.Core;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IBaseHeroFactory baseHeroFactory = new BaseHeroFactory();

            IEngine engine = new Engine(reader, writer, baseHeroFactory);

            engine.Run();
        }
    }
}
