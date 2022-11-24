using System;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumOfIntegers = 0;

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            FormatException formatException = new FormatException("The element '{0}' is in wrong format!");
            OverflowException overflowException = new OverflowException("The element '{0}' is out of range!");
            
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    long number = 0;

                    bool IsNumber = long.TryParse(input[i], out number);

                    if (!IsNumber)
                    {
                        throw formatException;
                    }

                    if (number<int.MinValue || number>int.MaxValue)
                    {
                        throw overflowException;
                    }  

                    sumOfIntegers += Convert.ToInt32(number);

                }
                catch (FormatException)
                {
                    Console.WriteLine(String.Format(formatException.Message, input[i]));
                }
                catch (OverflowException)
                {
                    Console.WriteLine(String.Format(overflowException.Message, input[i]));
                }
                finally
                {
                    Console.WriteLine($"Element '{input[i]}' processed - current sum: {sumOfIntegers}");
                }

            }
            Console.WriteLine($"The total sum of all integers is: {sumOfIntegers}");


        }
    }
}
