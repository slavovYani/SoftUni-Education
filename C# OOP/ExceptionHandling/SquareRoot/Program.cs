
namespace SquareRoot
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            
            ArithmeticException arithmeticException = new ArithmeticException("Invalid number.");

            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number<0)
                {
                    throw arithmeticException;
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArithmeticException)
            {
                
                Console.WriteLine(arithmeticException.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
            
        }
    }
}
