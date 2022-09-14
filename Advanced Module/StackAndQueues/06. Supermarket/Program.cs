using System;
using System.Collections.Generic;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string commandOrName = Console.ReadLine();
            Queue<string> names = new Queue<string>();

            while (commandOrName!="End")
            {
                if (commandOrName=="Paid")
                {
                    while (names.Count>0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                    
                }
                else if (commandOrName!="Paid")
                {
                names.Enqueue(commandOrName);   

                }
                 

                commandOrName = Console.ReadLine();
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
