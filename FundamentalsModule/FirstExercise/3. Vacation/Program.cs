using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            A count of people who are going on vacation.
            //          • Type of the group(Students, Business or Regular).
            //          • The day of the week which the group will stay on(Friday, Saturday or Sunday).
            //          Based on the given information calculate how much the group will pay for the entire vacation.
            //          The price for a single person is as follows:

            //                     Friday    Saturday    Sunday
            //          Students    8.45      9.80       10.46
            //          Business    10.90      15.60      16
            //          Regular      15         20       22.50

            //          There are also discounts based on some conditions:
            //•          For Students – if the group is 30 or more people, you should reduce the total price by 15 %.
            //•             For Business – if the group is 100 or more people, 10 of the people stay for free.
            //•             For Regular – if the group is between 10 and 20 people(both inclusively), reduce the total price by 5 %.
            //          Note: You should reduce the prices in that EXACT order!


            int peopleOnVacation = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0;

            if (typeOfGroup=="Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        totalPrice = peopleOnVacation * 8.45;
                        break;
                    case "Saturday":
                        totalPrice = peopleOnVacation * 9.8;
                        break;
                    case "Sunday":
                        totalPrice = peopleOnVacation * 10.46;
                        break;
                }

            }
            else if (typeOfGroup=="Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        totalPrice = peopleOnVacation * 10.9;
                        break;
                    case "Saturday":
                        totalPrice = peopleOnVacation * 15.6;
                        break;
                    case "Sunday":
                        totalPrice = peopleOnVacation * 16;
                        break;
                }
            }
            else if (typeOfGroup=="Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        totalPrice = peopleOnVacation * 15;
                        break;
                    case "Saturday":
                        totalPrice = peopleOnVacation * 20;
                        break;
                    case "Sunday":
                        totalPrice = peopleOnVacation * 22.5;
                        break;
                }
            }

            if (peopleOnVacation >= 30 && typeOfGroup == "Students")
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (typeOfGroup == "Business" && peopleOnVacation >= 100)
            {
                double pricePerPerson = totalPrice / peopleOnVacation;
                totalPrice -= pricePerPerson * 10;
            }
            else if (typeOfGroup == "Regular" && peopleOnVacation >= 10 && peopleOnVacation <= 20)
            {
                totalPrice = totalPrice * 0.95;
            }

        Console.WriteLine($"Total price: {totalPrice:f2}");
        }

    }
}
