using System;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // PrintNames("Steve", "Teddy");
           // PrintNames("Peter", "Sam", "Jay", "Chriss");

           //void PrintNames(params string[] names)
           // {
           //     foreach (var name in names)
           //         Console.WriteLine(name);
               
           // }

            IComparer<Cat> comparer = new CatComparer();

            Cat toni = new Cat() { Name="Toni"};
            Cat yani = new Cat() { Name="Ani"};
            Cat gosho = new Cat() { Name="Gosho"};

            var catsByName = new SortedSet<Cat>(comparer);
            catsByName.Add(toni);
            catsByName.Add(yani);
            catsByName.Add(gosho);
            

            
        }
    }
    
    class Cat
    {
        public string Name { get; set; }
    }
    class CatComparer : IComparer<Cat>
    {
        public int Compare(Cat x, Cat y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }


}
