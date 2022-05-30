using System;


namespace FirstProjectCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double interest = amount * procent / 100;
            double month = interest / 12;
            double overall = amount + (month * period);

            Console.WriteLine(overall);























        }
    }
}
