using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vlogger> VloggersInfo = new Dictionary<string, Vlogger>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Statistics")
            {

                string firstVlogger = input[0];
                string secondVlogger = input[2];
                string command = input[1];

                

                if (command == "joined")
                {

                    if (!VloggersInfo.ContainsKey(firstVlogger))
                    {
                        VloggersInfo.Add(firstVlogger,new Vlogger(firstVlogger));

                        //VloggersInfo[firstVlogger].Name = firstVlogger;
                        //VloggersInfo[firstVlogger].Following = new HashSet<string>();
                        //VloggersInfo[firstVlogger].Followers = new HashSet<string>();

                    }

                }
                else if (command == "followed")
                {
                    if (VloggersInfo.ContainsKey(firstVlogger) && VloggersInfo.ContainsKey(secondVlogger))
                    {

                        if (firstVlogger != secondVlogger)
                        {

                            VloggersInfo[firstVlogger].Following.Add(VloggersInfo[secondVlogger].Name);

                            VloggersInfo[secondVlogger].Followers.Add(VloggersInfo[firstVlogger].Name);
                        }

                    }




                }



                input = Console.ReadLine().Split();

            }

            Console.WriteLine($"The V-Logger has a total of {VloggersInfo.Count} vloggers in its logs.");


            foreach (var vlogger in VloggersInfo)
            {


                VloggersInfo = VloggersInfo.OrderByDescending(x => x.Value.Followers.Count).ThenBy(x => x.Value.Following.Count).ToDictionary(x => x.Key, y => y.Value);
            }

            int count = 1;

            foreach (var vlogger in VloggersInfo)
            {

                
                Console.WriteLine($"{count++}. {vlogger.Value.Name} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");
                if (count == 2)
                {
                    foreach (var follower in vlogger.Value.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");

                    }

                }
            }


        }
    }
    public class Vlogger
    {
        public Vlogger(string name)
        {
            Name = name;
            Followers = new HashSet<string>();
            Following = new HashSet<string>();
        }

        public string Name { get; set; }
        public HashSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }



    }
}
