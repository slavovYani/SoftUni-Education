using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethod
{
    public class Box<T> where T : IComparable
    {

        public List<T> Items { get; set; }

        public Box()
        {
            Items = new List<T>();
        }

        public int Compare(T itemToCompare)
        {
            //Predicate<T> filter = i => i.CompareTo(itemToCompare) < 0;
            int counter = 0;
            foreach (var item in Items)
            {
                if (item.CompareTo(itemToCompare)>0)
                {
                    counter++;
                }
            }

            return counter;
        }


    }
}
