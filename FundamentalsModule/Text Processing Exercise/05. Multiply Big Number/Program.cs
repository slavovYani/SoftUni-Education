using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigInteger = new BigInteger();
            
            bigInteger = BigInteger.Parse(Console.ReadLine());
            short secondNum = short.Parse(Console.ReadLine());
            BigInteger result = bigInteger * secondNum;

            Console.WriteLine(result);

        }
    }
}
