
namespace Stealer
{
    using System;
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            //System.Console.WriteLine(spy.StealFieldInfo("Stealer.Hacker", "username", "password"));

            //Console.WriteLine(spy.AnalyzeAccessModifiers("Stealer.Hacker"));

            //Console.WriteLine(spy.RevealPrivateMethods("Stealer.Hacker"));

            Console.WriteLine(spy.CollectGettersAndSetters("Stealer.Hacker"));

        }
    }
    
}
