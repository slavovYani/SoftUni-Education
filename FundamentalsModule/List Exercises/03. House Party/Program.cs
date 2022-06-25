using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<string> commandFor = new List<string>();
            List<string> listWithNames = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                commandFor = Console.ReadLine().Split().ToList();

                listWithNames = CheckTheNameInTheList(listWithNames, commandFor);

            }

            PrintingTheNames(listWithNames);
            
        }

        private static List<string> CheckTheNameInTheList(List<string> listWithNames, List<string> commandFor)
        {

            string name = commandFor[0];
            string goingOrNotCommand = commandFor[2];         
            bool containsOrNot = listWithNames.Contains(name);

                if (!containsOrNot&& goingOrNotCommand!="not")
                {
                    listWithNames.Add(name);
                    return listWithNames;
                }
                else if(containsOrNot && goingOrNotCommand != "not")
                {
                    Console.WriteLine($"{name} is already in the list!");
                    return listWithNames;

                }

                if (containsOrNot&& goingOrNotCommand=="not")
                {

                    listWithNames.Remove(name);
                    return listWithNames;

                }

                if (!containsOrNot&& goingOrNotCommand=="not")
                {

                    Console.WriteLine($"{name} is not in the list!");
                    return listWithNames; 

                }

            
            return listWithNames;

        }

        private static void PrintingTheNames(List<string> listWithNames)
        {
            for (int i = 0; i < listWithNames.Count; i++)
            {
                Console.WriteLine(listWithNames[i]);
            }
        }
    }
}
