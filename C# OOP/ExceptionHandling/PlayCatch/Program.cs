using System;
using System.Linq;

namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int exceptionCounter = 0;

            IndexOutOfRangeException indexOutOfRange = new IndexOutOfRangeException("The index does not exist!");
            FormatException formatException = new FormatException("The variable is not in the correct format!");

            while (exceptionCounter<3)
            {

                try
                {
                    string[] commArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string command = commArgs[0];
                    int index = int.Parse(commArgs[1]);

                    if (command == "Replace")
                    {
                        int value = int.Parse(commArgs[2]);

                        numbers[index] = value;

                    }
                    else if (command == "Show")
                    {
                        Console.WriteLine(numbers[index]);
                    }
                    else if (command == "Print")
                    {
                        int endIndex = int.Parse(commArgs[2]);

                        if (endIndex>=numbers.Length)
                        {
                            throw indexOutOfRange;
                        }

                        int[] currIntArr = new int[endIndex - index + 1];

                        
                            for (int j = 0; j < currIntArr.Length; j++)
                            {
                                currIntArr[j] = numbers[index++];
                            }
                            
                        
                        Console.WriteLine(String.Join(", ", currIntArr));
                        
                    }
                   
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(indexOutOfRange.Message);
                    exceptionCounter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine(formatException.Message);
                    exceptionCounter++;
                }   
                

            }

            Console.WriteLine(String.Join(", ",numbers));
        }
    }
}
