using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>(); 

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0]=="End")
                {
                    break;
                }
                var person = new Person();
                person.Name = input[0];
                person.ID= int.Parse(input[1]);
                person.Age = int.Parse(input[2]);

                persons.Add(person);

                Person currentPerson=persons.Find(person=>person.ID==int.Parse(input[1]));  
                currentPerson.Age = int.Parse(input[2]); 
                currentPerson.Name = input[0];

            }

            persons=persons.OrderBy(person=>person.Age).ToList();

            persons.ForEach(person => Console.WriteLine(person));
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int ID  { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
