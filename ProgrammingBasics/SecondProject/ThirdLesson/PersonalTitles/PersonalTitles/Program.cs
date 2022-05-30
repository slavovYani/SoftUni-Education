using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            //            &quot; Mr.& quot; – мъж(пол &#39;m&#39;) на 16 или повече години
            // &quot; Master & quot; – момче(пол &#39;m&#39;) под 16 години
            // &quot; Ms.& quot; – жена(пол &#39;f&#39;) на 16 или повече години
            // &quot; Miss & quot; – момиче(пол &#39;f&#39;) под 16 години

            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            bool ageIsMore = age >= 16;
            bool ageIsLess = age < 16;
            bool sexIsM = sex == "m";
            bool sexIsF = sex == "f";
            if (ageIsMore && sexIsM)
            {
                Console.WriteLine("Mr.");
            }
            else if (ageIsMore && sexIsF)
            {
                Console.WriteLine("Ms.");
                
            }
            if (ageIsLess && sexIsM)
            {
                Console.WriteLine("Master");
            }
            else if (ageIsLess && sexIsF)
            {

                Console.WriteLine("Miss");
            }




        }

    }
    }

