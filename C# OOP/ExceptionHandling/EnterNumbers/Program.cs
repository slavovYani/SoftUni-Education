using System;

class EnterNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;
        int counter = 0;
        int[] numbers = new int[10];

        while (counter < 10)
        {
            try
            {
                start = ReadNumbers(start, end);
                numbers[counter] = start;
                counter++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Your number is not in range {start} - 100!");
            }
            
        }

        
            Console.Write(String.Join(", ",numbers));
        
    }

    public static int ReadNumbers(int start, int end)
    {
       
        int num = int.Parse(Console.ReadLine());

        if (num <= start || num >= end)
        {
            throw new ArgumentException("Your number is not in the requested range!");
        }

        return num;
    }
}