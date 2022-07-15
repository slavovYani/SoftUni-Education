using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] currentStudent = Console.ReadLine().Split().ToArray();
                string firstName = currentStudent[0];
                string lastName= currentStudent[1];
                double grade = double.Parse(currentStudent[2]);

                Student student = new Student(firstName,lastName,grade);

                students.Add(student);
            }

            List<Student> sortedStudents = students.OrderByDescending(student=> student.Grade).ToList();

            sortedStudents.ForEach(student => Console.WriteLine(student));
        }


    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
            
            
        }
    }
}
