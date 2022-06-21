using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string inputPassword = Console.ReadLine();

            bool LenghtPassword = LenghtOfPassword(inputPassword);
            bool LettersAndDigit = LettersAndDigits(inputPassword);
            bool TwoDigits = AtLeastTwoDigits(inputPassword);

            if (LenghtPassword && LettersAndDigit && TwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool AtLeastTwoDigits(string inputPassword)
        {
            bool twoDigits = false;
            int digitCounter = 0;
            foreach (char symbol in inputPassword)
            {
                if (char.IsDigit(symbol))
                {
                    digitCounter++;
                    
                }

            }

            if (digitCounter >= 2)
            {
                twoDigits = true;
            }
            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                
            }
            return twoDigits;
        }

        private static bool LettersAndDigits(string inputPassword)
        {
            bool OnlyLettersAndDigits = false;
            foreach (char symbol in inputPassword)
            {
                if(char.IsLetterOrDigit(symbol))
                {
                    OnlyLettersAndDigits = true;
                }
                else
                {
                    OnlyLettersAndDigits = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                    break;

                }
            }
                return OnlyLettersAndDigits;
            
        }

        private static bool LenghtOfPassword(string input)
        {
            bool EnoughPasswordLenght = false;
            if (input.Length>=6&& input.Length<=10)
            {
                EnoughPasswordLenght = true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            return EnoughPasswordLenght;
        }


    }
}
