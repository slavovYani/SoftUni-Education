using System;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(w=>w.Length%2==0).ToArray();

            Array.ForEach(words,word => Console.WriteLine(word));
        }
    }
}
