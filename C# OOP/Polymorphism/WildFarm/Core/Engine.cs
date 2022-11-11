
namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Exceptions;
    using WildFarm.Factories;
    using WildFarm.Factories.Interfaces;
    using WildFarm.IO;
    using WildFarm.Models.Animal;
    using WildFarm.Models.Food;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory; // here for checking
        private readonly  ICollection<Animal> animals;

        private Engine()
        {
            this.animals = new HashSet<Animal>();
        }
        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory) : this()
        {
            this.reader = reader;
            this.writer = writer;
            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }


        public void Run()
        {

            string command;
            Animal currentAnimal = null;
            Food currentFood = null;

            while ((command = reader.ReadLine()) != "End")
            {

                try
                {
                    currentAnimal = MakeAnimalByFactory(command);
                    string[] foodInput = reader.ReadLine().Split();
                    currentFood = MakeFood(foodInput);

                    writer.WriteLine(currentAnimal.MakeNoise());
                    currentAnimal.Eat(currentFood);

                }
                catch (InvalidTypeException ite)
                {

                    writer.WriteLine(ite.Message);
                }
                catch (NotEatableFoodException nefe)
                {
                    writer.WriteLine(nefe.Message);
                }
                catch (Exception)
                {
                    throw;
                }

                animals.Add(currentAnimal);

            }

            foreach (var animal in animals)
            {
                writer.WriteLine(animal.ToString()); // here not sure ??
            }
        }
        private Food MakeFood(string[] foodInput)
        {

            string foodType = foodInput[0];
            int foodQuantity = int.Parse(foodInput[1]);
            Food currentFood = foodFactory.CreateFoodFactory(foodType, foodQuantity);
            return currentFood;
        }
        private Animal MakeAnimalByFactory(string command)
        {
            Animal currentAnimal;
            string[] animalInput = command.Split();

            currentAnimal = animalFactory.CreateAnimal(animalInput);
            return currentAnimal;
        }
    }
}
