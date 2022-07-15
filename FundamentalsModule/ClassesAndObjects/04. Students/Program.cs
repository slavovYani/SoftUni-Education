using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] != "end")
                {
                Student student = new Student(input[0],input[1],int.Parse(input[2]),input[3]);
                    listOfStudents.Add(student);
                }


                if (input[0]=="end")
                {
                    string nameOfCity = Console.ReadLine();

                    foreach (Student student in listOfStudents)
                    {
                        if (nameOfCity == student.HomeTown)
                        {
                            Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                        }

                    }
                    return;

                }
                
                    
                
            }
        }
    }
    class Student
    {
        public Student(string firstName,string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
