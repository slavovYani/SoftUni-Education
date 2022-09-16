using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short myFoodQuantity = short.Parse(Console.ReadLine());

            short[] orders = Console.ReadLine().Split().Select(short.Parse).ToArray();

            Queue<short> queueForOrders = new Queue<short>(orders);
            

            Console.WriteLine(queueForOrders.Max());

            while (queueForOrders.Count > 0)
            {

            short currentOrder = queueForOrders.Peek();

                if (myFoodQuantity - currentOrder >= 0)
                {

                    currentOrder = queueForOrders.Dequeue();
                    myFoodQuantity -= currentOrder;
                    continue;

                }
                break;
                
                
            }

            if (queueForOrders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queueForOrders)}");



            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
