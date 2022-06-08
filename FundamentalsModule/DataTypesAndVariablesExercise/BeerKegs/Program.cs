using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            string modelOfKeg;
            float radiusOfKeg = 0;
            int heightOfKed = 0;
            double volumeOfKegBiggest = double.MinValue;
            string biggestModelOfKeg = "";

            for (int i = 0; i < nLines; i++)
            {
                modelOfKeg = Console.ReadLine();
                radiusOfKeg = float.Parse(Console.ReadLine());
                heightOfKed = int.Parse(Console.ReadLine());

                 double volumeOfKegActual = Math.PI * Math.Pow(radiusOfKeg, 2) * heightOfKed;

                if (volumeOfKegBiggest<volumeOfKegActual)
                {
                    volumeOfKegBiggest=volumeOfKegActual;
                    biggestModelOfKeg = modelOfKeg;
                        
                }

            }
            Console.WriteLine(biggestModelOfKeg);
        }
    }
}
