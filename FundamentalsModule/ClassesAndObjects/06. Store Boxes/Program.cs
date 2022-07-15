using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string productOrEnd = Console.ReadLine();

                if (productOrEnd=="end")
                {
                    break;
                }

                string[] token = productOrEnd.Split().ToArray();

                Box box = new Box
                {
                    SerialNumber = token[0],
                    Item = new Item
                    {
                        Name = token[1],
                        PriceOfItem = decimal.Parse(token[3])
                    },

                    Quantity=int.Parse(token[2]),

                };

                boxes.Add(box);
            }
            List<Box> orderedBoxes = boxes.OrderByDescending(box => box.PriceOfBox).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.PriceOfItem:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceOfBox:f2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }
        public decimal PriceOfItem { get; set; }
        
    }
    class Box
    {
       
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceOfBox { get { return this.Quantity * this.Item.PriceOfItem; } }
         
    }
}
