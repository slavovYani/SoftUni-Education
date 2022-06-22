using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            bool listIsChanged = false;
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                int numberForFilter = 0;
                switch (command[0])
                {

                    case "Contains":
                        int numberContain = int.Parse(command[1]);
                        if (numbers.Contains(numberContain))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":

                        List<int> evenNumbers = PrintEven(numbers);
                        Console.WriteLine(string.Join(" ",evenNumbers));

                        break;
                    case "PrintOdd":
                        List<int> oddNumbers = PrintOdd(numbers);
                        Console.WriteLine(string.Join(" ", oddNumbers));
                        
                        break;
                    case "GetSum":

                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        numberForFilter = int.Parse(command[2]);
                        FilterTheNumber(command[1],numberForFilter,numbers);
                        Console.WriteLine();
                        break;

                    case "Add":
                        int numberToAdd = int.Parse(command[1]);
                        numbers.Add(numberToAdd);
                        listIsChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(command[1]);
                        numbers.Remove(numberToRemove);
                        listIsChanged = true;

                        break;
                    case "RemoveAt":
                        int numbersToRemoveAt = int.Parse(command[1]);
                        numbers.RemoveAt(numbersToRemoveAt);
                        listIsChanged = true;

                        break;
                    case "Insert":
                        int numbersToInsert = int.Parse(command[1]);
                        int indexToInsert = int.Parse(command[2]);
                        numbers.Insert(indexToInsert, numbersToInsert);
                        listIsChanged = true;

                        break;
                    case "end":
                        EndingTheProgram(numbers,listIsChanged);
                        
                        return;

                }



            }



        static void FilterTheNumber(string condition, int numberInCondition, List<int> numbers)
            {
                switch (condition)
                {
                    case "<":
                        
                        foreach (var number in numbers)
                        {
                            if (number < numberInCondition)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        break;

                    case ">":

                        foreach (var number in numbers)
                        {
                            if (number > numberInCondition)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        break;
                    case "<=":

                        foreach (var number in numbers)
                        {
                            if (number <= numberInCondition)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        break;

                    case ">=":

                        foreach (var number in numbers)
                        {
                            if (number >= numberInCondition)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        break;
                }
            }
        }

        private static void EndingTheProgram(List<int> numbers, bool isListChanged)
        {
            if (isListChanged)
            {
                Console.WriteLine(string.Join(" ",numbers));
                
            }
            else
            {
                return;
            }
            
        }

        private static List<int> PrintOdd(List<int> numbers)
        {
            List<int> oddNumbers = new List<int>();
            foreach (var number in numbers)
            {

                if (number % 2 != 0)
                {
                    oddNumbers.Add(number);
                }
            }
            return oddNumbers;
        }

        private static List<int> PrintEven(List<int> numbers)
        {
            List<int> evenNumber = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumber.Add(number);
                }
                
                
            }
                return evenNumber;


        }
    } 
}

