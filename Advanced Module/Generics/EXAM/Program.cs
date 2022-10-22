using System;
using System.Collections.Generic;

namespace EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> list = new List<long>();
            list.Add(46);
            list.Add(23);
            Console.WriteLine(string.Join(Environment.NewLine, getMinOperations(list)));

        }
        public static List<int> getMinOperations(List<long> kValues)
        {
            long startinInt = 1;
            Func<long, long> add1 = n => n + 1;
            Func<long, long> multiply2 = n => n * 2;
            long counter = 1;
            List<long> list = new List<long>();


            for (int i = 0; i < kValues.Count; i++)
            {
                long desiredResult = kValues[i];

                while (true)
                {
                    
                    if(startinInt != desiredResult)
                    {
                        
                        if (add1(startinInt) == desiredResult)
                        {
                            counter++;
                            startinInt = add1(startinInt);
                            
                            
                        }
                        else if (multiply2(add1(startinInt)) == desiredResult)
                        {
                            counter += 2;
                            startinInt = multiply2(add1(startinInt));
                            
                            
                        }
                        else if (add1(multiply2(startinInt)) == desiredResult)
                        {
                            counter += 2;
                            startinInt = add1(multiply2(startinInt));
                            
                            
                        }
                        else if (multiply2(startinInt) <= desiredResult)
                        {
                            startinInt = multiply2(startinInt);
                            counter++;
                            
                           

                        }
                        else if(add1(startinInt)<=desiredResult)
                        {
                            startinInt=add1(startinInt);
                        }
                        
                    }
                    if (startinInt == desiredResult)
                    {

                        list.Add(counter);
                        startinInt = 1;
                        counter = 1;
                        break;
                    }

                    continue;
                }

            }

            List<int> result = new List<int>();
            foreach (var item in list)
            {
                result.Add((int)item);
            }

            return result;



        }
    }
}
