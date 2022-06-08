using System;

namespace _06.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char firstChar;
            char secondChar;
            char thirdChar;
            for (int i = 0; i < n; i++)
            {
                 firstChar = (char)('a' + i);
                
                for (int j = 0; j < n; j++)
                {
                    
                    secondChar = (char)('a' + j);
                    
                    for (int k = 0; k < n; k++)
                    {
                        
                        thirdChar = (char)('a' + k);

                        Console.Write($"{firstChar}{secondChar}{thirdChar}");
                        Console.WriteLine();
                    }
                }
                
            }

        }
    }
}
