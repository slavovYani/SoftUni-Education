
namespace WildFarm.Factories
{
    using Interfaces;
    using Models.Animal;
    using WildFarm.Exceptions;

    public class AnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal(string[] commdArgs)
        {
            Animal animal;

            string type = commdArgs[0];
            string name = commdArgs[1];
            double weight = double.Parse(commdArgs[2]);
            string fourthArg = commdArgs[3];


            if (type == "Owl")
            {
                animal = new Owl(name,weight, double.Parse(fourthArg));
            }
            else if (type == "Hen")
            {
                animal = new Hen(name, weight, double.Parse(fourthArg));
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, weight, fourthArg, commdArgs[4]);
            }
            else if (type == "Tiger")
            {
                animal = new Tiger(name, weight, fourthArg, commdArgs[4]);
            }
            else if (type == "Mouse")
            {
                animal = new Mouse(name, weight, fourthArg);
            }
            else if (type == "Dog")
            {
                animal = new Dog(name, weight, fourthArg);
            }
            else
            {
                throw new InvalidTypeException();
            }
            return animal;

        }
    }
}
