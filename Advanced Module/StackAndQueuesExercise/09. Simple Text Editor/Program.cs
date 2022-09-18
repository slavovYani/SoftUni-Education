using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfOperations = byte.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            text = text.Append("");
            Stack<string> textChanges = new Stack<string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] input = Console.ReadLine().Split();

                byte command = byte.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        string currentTextToAppend = input[1];
                        text = text.Append(currentTextToAppend);
                        textChanges.Push(text.ToString());
                        break;

                    case 2:
                        byte elementsToRemove = byte.Parse(input[1]);
                        text = text.Remove(text.Length - elementsToRemove, elementsToRemove);
                        textChanges.Push(text.ToString());
                        break;

                    case 3:
                        byte positionOfElement = byte.Parse(input[1]);
                        Console.WriteLine(text[positionOfElement-1]);
                        break;
                    case 4:
                        textChanges.Pop();
                        text = new StringBuilder(textChanges.Peek());
                       
                        break;
                    
                }
            }
        }
    }
}
