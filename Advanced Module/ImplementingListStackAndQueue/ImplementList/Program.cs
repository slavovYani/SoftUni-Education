using System;

namespace ImplementList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();

            list.Add(5);
            list.Add(8);
            list.Add(9);
            list.Add(12);
            list.Add(123);
            list.Add(15);
            list.Add(124);
            list.Add(128);

            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            list.RemoveAt(0);
            
            

            list.InsertAt(2, 255);
            
        }
    }
}
