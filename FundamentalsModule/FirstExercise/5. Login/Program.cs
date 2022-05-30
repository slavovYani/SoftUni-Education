using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string usernameReverse = "";
            string password = Console.ReadLine();
            int wrongPasswordCounter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                usernameReverse += username[i];
               
            }
            while (usernameReverse != password && wrongPasswordCounter<3)
            {
                    Console.WriteLine("Incorrect password. Try again.");
                    password = Console.ReadLine();
                wrongPasswordCounter++;
            }
            if (usernameReverse==password)
            {
                Console.WriteLine($"User {username} logged in.");
                return;
            }
            if (wrongPasswordCounter>=3)
            {
                Console.WriteLine($"User {username} blocked!");
            }

            

        }
    }
}
