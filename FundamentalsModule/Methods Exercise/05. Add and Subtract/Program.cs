using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

           int result = SumOfIntegers(firstNumber,secondNumber);
            Console.WriteLine(FinalResult(result, thirdNumber)); 
        }

        private static int FinalResult(int result, int thirdN) => result - thirdN;


        private static int SumOfIntegers(int firstN, int secondN) => firstN + secondN;
       
    }
}
