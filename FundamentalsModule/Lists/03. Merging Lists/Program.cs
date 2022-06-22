using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int biggerCounter = Math.Max(firstList.Count, secondList.Count);


            for (int i = 0; i < biggerCounter; i++)
            {
                if (firstList.Count > i)
                {
                    result.Add(firstList[i]);
                }

                if (secondList.Count > i)
                {
                    result.Add(secondList[i]);
                }

            }

            Console.WriteLine(string.Join(" ", result));


            //Another try

            //List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> biggerList = new List<int>();
            //List<int> smallerList = new List<int>();
            
            //List<int> resultList = new List<int>();


            //if (firstList.Count < secondList.Count)
            //{
            //    biggerList = secondList;
            //    smallerList = firstList;

            //}
            //else
            //{
            //    biggerList = firstList;
            //    smallerList = secondList;
            //}

            //for (int i = 0; i < biggerList.Count; i++)
            //{
            //    if (firstList.Count>0)
            //    {
            //    int firstListNumber = firstList[i];
            //        resultList.Add(firstListNumber);
            //        firstList.RemoveAt(i);

            //    }
            //        i = -1;

            //    for (int j = 0; j < biggerList.Count; j++)
            //    {
            //        if (secondList.Count>0)
            //        {
            //        int secondListNumber = secondList[j];
            //        resultList.Add(secondListNumber);
            //            secondList.RemoveAt(j);
                        
            //            break;
            //        }

            //    }

            //}


            //int indexSmallList = 0;

            //for (int i = 0; i < biggerList.Count; i++)
            //{


            //        int numberFromBigList = biggerList[i];
            //        resultList.Add(numberFromBigList);



            //    while (smallerList.Count>indexSmallList)
            //    {

            //        int numberFromSmallList = smallerList[indexSmallList];
            //        resultList.Add(numberFromSmallList);
            //        indexSmallList++;
            //        break;
            //    }


            //}

            //Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
