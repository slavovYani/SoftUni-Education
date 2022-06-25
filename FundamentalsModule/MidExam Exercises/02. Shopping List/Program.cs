using System;
using System.Linq;

namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //int waitingPeople = int.Parse(Console.ReadLine());
            //int[] currentState = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //for (int i = 0; i < currentState.Length; i++)
            //{

            //    if (currentState[i]<4)
            //    {
            //      int freeSpaceInState = 4 - currentState[i];

            //        if (freeSpaceInState>waitingPeople)
            //        {
            //            currentState[i] += waitingPeople;
            //            waitingPeople -= currentState[i];
            //        }
            //        else
            //        {
            //        currentState[i] +=freeSpaceInState;
            //        waitingPeople -= freeSpaceInState;

            //        }

            //    }
            //    if (waitingPeople==0)
            //    {
            //        foreach (var state in currentState)
            //        {
            //            if (state!=4)
            //            {
            //                Console.WriteLine("The lift has empty spots!");
            //                Console.WriteLine(string.Join(" ", currentState));
            //            }
            //        }


            //    }
            //    else if (waitingPeople>0 & currentState.AsQueryable().All(val=> val==4))
            //    {
            //        Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
            //        Console.WriteLine(string.Join(" ",currentState));
            //    }

            int waitingPeople = int.Parse(Console.ReadLine());
            int[] state = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxPeopleInWagon = 4;

            for (int i = 0; i < state.Length; i++)
            {
                for (int j = state[i]; j < maxPeopleInWagon; j++)
                {
                    state[i]++;
                    waitingPeople--;

                    if (waitingPeople == 0)
                    {
                        if (state.Sum() < state.Length * maxPeopleInWagon)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }

                        Console.WriteLine(string.Join(' ', state));

                        return;
                    }
                }
            }

            Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
            Console.WriteLine(string.Join(' ', state));



        }
    }
}


