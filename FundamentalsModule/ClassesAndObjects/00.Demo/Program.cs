using System;

namespace _00.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Dog John = new Dog { Name = "Ivan", Age = 5, Weight = 12 };
            Console.WriteLine(John.Name);

            Dog Rufus = new Dog();
            Rufus.Name = "Ruff";
            Rufus.Age = 5;
            Rufus.Weight = 7;
            Rufus.Bark();

            var Gosho = new Dog(name, 5);
            Console.WriteLine(Gosho.Weight);
            Gosho.Bark();
        }
    }
    class Dog
    {
        public Dog()
        {

        }
        public Dog(string name, int age)
        {

            Name = name;
            Age = age;
            
        }

        public string Name  { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public void Bark()
        {
            Console.WriteLine(this.Name);
        }


    }

}
