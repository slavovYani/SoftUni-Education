using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                string[] colorWithClothes = Console.ReadLine().Split(" -> ").ToArray();
                string color = colorWithClothes[0];
                string[] items = colorWithClothes[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(color))
                {

                    wardrobe.Add(color, new Dictionary<string, int>());

                    for (int j = 0; j < items.Length; j++)
                    {

                        if (!wardrobe[color].ContainsKey(items[j]))
                        {

                            wardrobe[color].Add(items[j], 0);
                        }

                        wardrobe[color][items[j]]++;
                    }



                }
                else
                {

                    for (int k = 0; k < items.Length; k++)
                    {
                        if (!wardrobe[color].ContainsKey(items[k]))
                        {

                            wardrobe[color].Add(items[k], 0);
                        }

                        wardrobe[color][items[k]]++;

                    }

                }





            }

            string[] desiredDress = Console.ReadLine().Split();
            string found = "";
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {


                    Console.WriteLine($"* {item.Key} - {item.Value} " + FindClothe(wardrobe, ref desiredDress, item.Key));



                }
            }

        }

        public static string FindClothe(Dictionary<string, Dictionary<string, int>> wardrobe, ref string[] desiredDress, string currItem)
        {

            string found = "";

            if (wardrobe.ContainsKey(desiredDress[0]))
            {
                foreach (var item in wardrobe[desiredDress[0]])
                {
                    if (item.Key == desiredDress[1]&& item.Key==currItem)
                    {
                        desiredDress = new string[] { "1", "2" };
                        return found = "(found!)";

                    }
                }



            }
            return found;
        }
    }
}
