﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfInteger
{
    public class Box<T>
    {
        public List<T> Items { get; set; }

        public Box()
        {
            Items = new List<T>();

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item} ");
            }

            return sb.ToString().TrimEnd();

        }
    }
}
