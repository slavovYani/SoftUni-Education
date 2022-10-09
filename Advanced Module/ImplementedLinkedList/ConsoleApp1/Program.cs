using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddFirst(4);

            list.ForEach(n => Console.WriteLine(n));
        }
    }
}
