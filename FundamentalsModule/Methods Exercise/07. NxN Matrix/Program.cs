using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            _NxN_Matrix(n);
        }

        private static void _NxN_Matrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 1; j < number; j++)
                {
                Console.Write(number+" ");

                }
                Console.WriteLine(number);
            }
        }
    }
}
