using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] persons = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray(); // if input is invalid here??
            List<Person> listOfPersons = new List<Person>();

            string[] products = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Product> listOfProducts = new List<Product>();

            try
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    string[] currentPerson = persons[i].Split('=').ToArray();
                    string name = currentPerson[0];
                    double money = double.Parse(currentPerson[1]);

                    Person person = new Person(name, money);
                    listOfPersons.Add(person);

                }


                for (int i = 0; i < products.Length; i++)
                {
                    string[] currentProduct = products[i].Split('=').ToArray();
                    string name = currentProduct[0];
                    double cost = double.Parse(currentProduct[1]);

                    Product product = new Product(name, cost);
                    listOfProducts.Add(product);

                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
                return;
            }


            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "END")
            {
                string person = command[0];
                string desiredProduct = command[1];

                var currPerson = listOfPersons.First(p => p.Name == person);
                var currProduct = listOfProducts.First(p => p.Name == desiredProduct);

                if (currPerson.Money >= currProduct.Cost)
                {
                    currPerson.Money -= currProduct.Cost;
                    Console.WriteLine($"{currPerson.Name} bought {currProduct.Name}");
                    currPerson.BagOfProducts.Add(currProduct);
                }
                else
                {
                    Console.WriteLine($"{currPerson.Name} can't afford {currProduct.Name}");
                }




                command = Console.ReadLine().Split().ToArray();
            }


            listOfPersons.ForEach(p => Console.WriteLine(p));
        }
    }
}
