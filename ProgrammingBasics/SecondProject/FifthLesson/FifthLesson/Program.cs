using System;

namespace FifthLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double gradeTotal = 0;
            int gradeNumber = 1;
            int falseGrade = 0;

            while (gradeNumber<=12)
            {
                double studentGrade = double.Parse(Console.ReadLine());

                if (studentGrade >= 4)
                {
                    gradeTotal += studentGrade;
                gradeNumber++;
                }
                else
                {
                    falseGrade++;
                    if (falseGrade == 2)
                    {
                        
                    Console.WriteLine($"{studentName} has been excluded at {gradeNumber} grade");
                        return;
                    }
                }

                
            }
            double averageGrade = gradeTotal / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");


        }
    }
}
