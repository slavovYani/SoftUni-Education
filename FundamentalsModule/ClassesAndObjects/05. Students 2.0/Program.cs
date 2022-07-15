using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> listOfStudents = new List<Student>();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();


                if (input[0] == "end")
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

                if (isStudentExisting(listOfStudents,input[0],input[1],input[2],input[3]))
                {

                }
                else
                {
                    Student student = new Student(input[0], input[1], int.Parse(input[2]), input[3]);
                    listOfStudents.Add(student);

                }





            }
        }

         public static bool isStudentExisting(List<Student> listOfStudents,string firstName, string lastName,string age,string homeTown)
        {
            int ageInteger = int.Parse(age);
            foreach (Student student in listOfStudents)
            {
                if (firstName == student.FirstName && lastName == student.LastName)
                {
                    student.Age = ageInteger;
                    return true;
                }

            }
            return false;
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
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
    

