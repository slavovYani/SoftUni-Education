<<<<<<< HEAD
﻿
using System;

namespace ConsoleApp1
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person person = new Person(input[0], int.Parse(input[1]));


                family.AddMember(person);

            }

            var sortedPersons = family.GetPersonsAbove30();

            foreach (var person in sortedPersons)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
=======
﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
>>>>>>> parent of 35f36b3 (Update)
