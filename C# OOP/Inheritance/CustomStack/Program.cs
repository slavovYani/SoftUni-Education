using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stackOfStrings = new StackOfStrings();

            stackOfStrings.AddRange("Gosho", "Mitko", "Ivan");

            Console.WriteLine(stackOfStrings.Count);

            Console.WriteLine(stackOfStrings.IsEmpty());

        }
    }
}
