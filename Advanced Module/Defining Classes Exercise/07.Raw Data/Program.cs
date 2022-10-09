using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());


            List<Car> cars = new List<Car>();


            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < numberOfCars; i++)
            {

                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                float tirePressure1 = float.Parse(carInfo[5]);
                int tireAge1 = int.Parse(carInfo[6]);
                float tirePressure2 = float.Parse(carInfo[7]);
                int tireAge2 = int.Parse(carInfo[8]);
                float tirePressure3 = float.Parse(carInfo[9]);
                int tireAge3 = int.Parse(carInfo[10]);
                float tirePressure4 = float.Parse(carInfo[11]);
                int tireAge4 = int.Parse(carInfo[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tires[] tires = new Tires[4]
                {
                    new Tires(tireAge1,tirePressure1),
                    new Tires(tireAge2,tirePressure2),
                    new Tires(tireAge3,tirePressure3),
                    new Tires(tireAge4,tirePressure4)
                };

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);

                carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            var correctedCars = new List<Car>();

            if (carInfo[0] == "fragile")
            {
                correctedCars = cars.Where(c => c.Cargo.Type == "fragile").Where(c => c.Tires.Any(t => t.Pressure < 1)).ToList();
            }
            else
            {
                correctedCars = cars.Where(c => c.Cargo.Type == "flammable").Where(c => c.Engine.Power > 250).ToList();

            }

            correctedCars.ForEach(c => Console.WriteLine(c.Model));



        }
    }
}
