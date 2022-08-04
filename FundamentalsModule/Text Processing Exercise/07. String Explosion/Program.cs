using System;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = new StringBuilder(Console.ReadLine());

            int securedPower = 0;
            for (int i = 0; i <= input.Length-2; i++)
            {
                if (input[i]=='>')
                {
                    var c = input[i+1].ToString();  
                    int power = int.Parse(c);
                    power += securedPower;

                    for (int j = 0; j < power; j++)
                    {
                        if (char.IsLetterOrDigit(input[i+1]))
                        {

                            if (input.Length-2==i)
                            {
                                break;
                            }
                            else
                            {
                            input.Remove(i + 1, 1);

                            }
                        }
                        
                        else
                        {
                            securedPower++;
                        }
                        
                    }

                    
                }
               
            }
            Console.WriteLine(input);
        }
    }
}
