using System;
using System.Text;

namespace Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encriptedMessage = Console.ReadLine();
            string[] command = Console.ReadLine().Split('|');
            var decodedMessage = new StringBuilder();
            decodedMessage.Append(encriptedMessage);
            string mainComand = command[0];

            while (mainComand!="Decode")
            {
                

                switch (mainComand)
                {
                    case "Move":
                        int numberOfLetters = int.Parse(command[1]);
                        encriptedMessage=decodedMessage.ToString();
                        decodedMessage.Append(encriptedMessage.Substring(0, numberOfLetters));
                        decodedMessage.Remove(0, numberOfLetters);
                        break;
                    case "Insert":
                        Insert(command, decodedMessage);

                        break;
                    case "ChangeAll":
                        decodedMessage.Replace(command[1], command[2]); 
                        break;
                }
                command = Console.ReadLine().Split('|');
                mainComand = command[0];
            }

            Console.WriteLine($"The decrypted message is: {decodedMessage.ToString()}");
        }

        public static void Insert(string[] command, StringBuilder decodedMessage)
        {
            int indexBefore = int.Parse(command[1]);
            var value = command[2];

            decodedMessage.Insert(indexBefore, value);
        }
    }
}
