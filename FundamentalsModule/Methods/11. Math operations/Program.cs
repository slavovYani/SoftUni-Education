using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char theChar = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Calculate(firstNumber, theChar, secondNumber);

            Console.WriteLine(Calculate(firstNumber,theChar,secondNumber));
        }

        private static double Calculate(int firstNumber, char @operator, int secondNumber)
        {
            double result = 0;

            switch (@operator)
            {
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
              
            }
            return result;

        }
    }
}
