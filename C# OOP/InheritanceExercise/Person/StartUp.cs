﻿using System;
using System.Dynamic;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Child child = new Child(name, age);

            Console.WriteLine(child);
        }
    }
}