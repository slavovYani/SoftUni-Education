using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {

        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                string[] token = command.Split("/").ToArray();

                string typeOfObject = token[0];

                switch (typeOfObject)
                {
                    case "Car":

                        Car car = new Car
                        {
                            Brand = token[1],
                            Model = token[2],
                            HorsePower = int.Parse(token[3])

                        };
                        catalog.Cars.Add(car);

                        break;

                    case "Truck":
                        Truck truck = new Truck
                        {
                            Brand = token[1],
                            Model = token[2],
                            Weight = int.Parse(token[3])

                        };

                        catalog.Trucks.Add(truck);

                        break;
                }


            }
            

            if (catalog.Cars.Count > 0)
            {
                List<Car> orderedCars = catalog.Cars.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Cars:");

                foreach (var car in orderedCars)
                {

                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

                }


            }
            if (catalog.Trucks.Count > 0)
            {
                List<Truck> orderedTruck = catalog.Trucks.OrderBy(c => c.Brand).ToList();

                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTruck)
                {

                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

                }

            }
        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        class Catalog
        {
            public Catalog()
            {
                this.Cars = new List<Car>();
                this.Trucks = new List<Truck>();

            }
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}
