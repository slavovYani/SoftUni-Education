using System;
using System.Runtime.Serialization.Formatters;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split();
            string[] input2 = Console.ReadLine().Split();
            string[] input3 = Console.ReadLine().Split();

            string city = string.Empty;

            if (input1.Length>4)
            {
                city = $"{input1[3]} {input1[4]}";
            }
            else
            {
                city = input1[3];
            }
            Threeuple<string, string,string> nameAndAdress = new Threeuple<string, string,string>() 
            {
               
                Item1=input1[0] + " "+ input1[1],
                Item2=input1[2],   
                Item3 =city
            };

            bool isDrunk = false;

            if (input2[2]=="drunk")
            {
                isDrunk = true;
            }
            else
            {
                isDrunk = false;
            }
            Threeuple<string, int, bool> nameAndBeers = new Threeuple<string, int, bool>()
            {
                Item1 = input2[0],
                Item2 = int.Parse(input2[1]),
                Item3 = isDrunk
            };

            Threeuple<string, double, string> numbers = new Threeuple<string, double, string>()
            {
                Item1 = input3[0],
                Item2 = double.Parse(input3[1]),
                Item3 = input3[2]
            };

            Console.WriteLine(nameAndAdress);
            Console.WriteLine(nameAndBeers);
            Console.WriteLine(numbers);


        }
    }
}
