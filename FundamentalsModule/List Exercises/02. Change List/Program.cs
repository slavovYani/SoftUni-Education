using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    
                    case "end":
                        Console.WriteLine(string.Join(" ", numbers));
                        return;

                    case "Delete":

                        int numberForDeleting = int.Parse(command[1]);
                        numbers = DeletingNumber(numberForDeleting, numbers);
                        break;

                    case "Insert":

                        int numberForInsert = int.Parse(command[1]);
                        int indexPosition = int.Parse(command[2]);
                        numbers.Insert(indexPosition, numberForInsert);
                        break;

                    
                }


            }
        }

        private static List<int> DeletingNumber(int numberForDeleting, List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]==numberForDeleting)
                {
                    numbers.RemoveAt(i);
                }
            }
            return numbers;
        }
    }
}
