using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queueOfSongs = new Queue<string>(inputSongs);

            while (queueOfSongs.Count > 0)
            {
                string[] commands = Console.ReadLine().Split();
                string currentCom = commands[0];

                switch (currentCom)
                {
                    case "Play":
                        queueOfSongs.Dequeue();
                        break;

                    case "Add":
                        queueOfSongs = AddMethod(commands, queueOfSongs);

                        break;
                    case "Show":
                        Console.WriteLine(String.Join(", ", queueOfSongs));

                        break;

                }


            }
            Console.WriteLine("No more songs!");


        }

        private static Queue<string> AddMethod(string[] commands, Queue<string> queueOfSongs)
        {
            string currentCommand = string.Join(" ", commands);

            string[] currentCom = currentCommand.Split("Add ");

            var currentSong = currentCom[1];

            if (queueOfSongs.Contains(currentSong))
            {
                Console.WriteLine(currentSong + " is already contained!");
            }
            else
            {
                queueOfSongs.Enqueue(currentSong);
            }

            return queueOfSongs;
        }
    }
}
