using System;

namespace P01_ShopingDelivery_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //            ресторант отваря врати и предлага няколко менюта на преференциални цени:
            //            • пилешко меню – 10.35 лв.
            //            • меню с риба – 12.40 лв.
            //            • вегетарианско меню – 8.15 лв.
            //            напишете програма, която изчислява колко ще струва на група хора да си поръчат храна за вкъщи.
            //            групата ще си поръча и десерт, чиято цена е равна на 20 % от общата сметка(без доставката).
            //            цената на доставка е 2.50 лв и се начислява най - накрая.
            //            вход
            //            от конзолата се четат 3 реда:
            //            брой пилешки менюта – цяло число в интервала[0 … 99]
            //            брой менюта с риба – цяло число в интервала[0 … 99]
            //           брой вегетариански менюта – цяло число в интервала[0 … 99]
            //            изход
            //            да се отпечата на конзолата един ред: &quot;
            //            { цена на поръчката}
            //            &quot;

            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double veggieMenuPrice = 8.15;
            double dessertProcentPrice = 0.2;
            double deliveryPrice = 2.5;

            double chickenMenus = double.Parse(Console.ReadLine());
            double fishMenus  = double.Parse(Console.ReadLine());
            double veggieMenus = double.Parse(Console.ReadLine());

            double chickenTotalPrice = chickenMenus * chickenMenuPrice;
            double fishTotalPrice = fishMenus * fishMenuPrice;
            double veggieTotalPrice = veggieMenus * veggieMenuPrice;

            double totalMenus = chickenTotalPrice + fishTotalPrice + veggieTotalPrice;
            double dessertTotal = totalMenus * dessertProcentPrice;
            double total = totalMenus + dessertTotal + deliveryPrice;

       
            
            Console.WriteLine(total);










        }
    }
}
