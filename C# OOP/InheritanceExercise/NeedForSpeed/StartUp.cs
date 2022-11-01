using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            FamilyCar familyCar = new FamilyCar(250,2000);

            familyCar.Drive(100);

            Console.WriteLine(familyCar.Fuel);

            Car car = new Car(250, 2000);

            car.Drive(100);

            Console.WriteLine(car.Fuel);

            var vehicle = new Vehicle(250, 2000);

            vehicle.Drive(100);

            Console.WriteLine(vehicle.Fuel);

        }
    }
}
