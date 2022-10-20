using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodInteger
{
    public class Box<T>
    {
        public List<T> List { get; set; }

        public Box()
        {
            List = new List<T>();

        }

        public void Swap(int[] indexes)
        {
            var currObj = List[indexes[0]];
            List[indexes[0]] = List[indexes[1]];
            List[indexes[1]]=currObj;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in List)
            {

                sb.AppendLine($"{typeof(T)}: {item}");
            }


            return sb.ToString();


        }
    }
}
