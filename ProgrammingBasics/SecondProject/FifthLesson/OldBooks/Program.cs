using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string desiredBook = Console.ReadLine();
            string searchingBook = Console.ReadLine();
            int bookCount = 0;

            while (searchingBook!="No More Books")
            {
                 bookCount++;
                 searchingBook = Console.ReadLine();
                if (desiredBook == searchingBook)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    return;

                }
                continue;
                
            }
            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {bookCount} books.");





        }
    }
}
