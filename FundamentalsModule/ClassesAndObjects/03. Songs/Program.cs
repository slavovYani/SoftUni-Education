using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> listOfSongs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] separetedInput = Console.ReadLine().Split("_").ToArray();
                
                 Song song = new Song(separetedInput[0],separetedInput[1],separetedInput[2]);

                listOfSongs.Add(song);

            }
            string typeListOrAll = Console.ReadLine();
            if (typeListOrAll=="all")
            {
                foreach (Song song in listOfSongs)
                {

                Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in listOfSongs)
                {
                    if (song.TypeList==typeListOrAll)
                    {
                        Console.WriteLine(song.Name);

                    }
                }   
            }
        }
    }
    class Song
    {
        public Song(string type,string name,string time)
        {
            this.TypeList = type;
            this.Name = name;
            this.Time = time;
        }
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
