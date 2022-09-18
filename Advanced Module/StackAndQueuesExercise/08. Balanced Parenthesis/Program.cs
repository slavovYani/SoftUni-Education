using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            char[] input = inputString.ToArray();

            Stack<char> validStack = new Stack<char>(short.MaxValue);

            if (input.Contains(' '))
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                {
                    validStack.Push(input[i]);
                }

                else
                {
                    if (validStack.Count>0)
                    {


                        switch (input[i])
                        {
                            case ')':
                                if ('(' == validStack.Peek())
                                {
                                    validStack.Pop();
                                }
                                else
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;
                            case '}':
                                if ('{' == validStack.Peek())
                                {
                                    validStack.Pop();
                                }
                                else
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;
                            case ']':
                                if ('[' == validStack.Peek())
                                {
                                    validStack.Pop();
                                }
                                else
                                {
                                    Console.WriteLine("NO");
                                    return;
                                }
                                break;

                            

                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }

            }

            if (validStack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}
