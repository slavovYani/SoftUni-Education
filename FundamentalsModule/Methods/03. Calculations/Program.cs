using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int result = 0;

            switch (firstLine)
              
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    
                    break;
                case "subtract":
                    Substract(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;

            }
            

        }

        static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber); 
            
        }

        static void Add(int firstNumber, int secondNumber)
        {
           Console.WriteLine(firstNumber + secondNumber);
        }

        static void Substract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber -secondNumber);
        }
        static void Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
