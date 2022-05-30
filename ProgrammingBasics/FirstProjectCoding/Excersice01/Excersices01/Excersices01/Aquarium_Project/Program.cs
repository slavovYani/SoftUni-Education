using System;

namespace P01_BasketballEquipment_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // За рождения си ден Любомир получил аквариум с формата на паралелепипед. Първоначално прочитаме от
            // конзолата на отделни редове размерите му – дължина, широчина и височина в сантиметри.Трябва да се
            //пресметне колко литра вода ще събира аквариума, ако се знае, че определен процент от вместимостта му е
            // заета от пясък, растения, нагревател и помпа.
            // Един литър вода се равнява на един кубичен дециметър / 1л = 1 дм 3 /.
            // Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.
            /*/
             * 
             */

            // От конзолата се четат 4 реда:
            // 1.Дължина в см – цяло число в интервала[10 … 500]
            // 2.Широчина в см – цяло число в интервала[10 … 300]
            // 3.Височина в см – цяло число в интервала[10… 200]
            // 4.Процент – реално число в интервала[0.000 … 100.000]
            // Изход
            // Да се отпечата на конзолата едно число:


            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double procentAccesoaries = double.Parse(Console.ReadLine());
            double accesoariesCoeficent = procentAccesoaries/100;

            double capacityInCentimeter = lenght * width * height;
            double capacityInLiter = capacityInCentimeter / 1000;

            double accesoaries = capacityInLiter * accesoariesCoeficent;
            double neededLiter = capacityInLiter -accesoaries;

            Console.Write(neededLiter);

            



        }
    }
}
