using System;
using System.Linq;

namespace _04.PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            try
            {
                string[] pizzaName = Console.ReadLine().Split(" " /*StringSplitOptions.RemoveEmptyEntries*/).ToArray();
                if (pizzaName.Length==1)
                {
                    throw new IndexOutOfRangeException("Pizza name should be between 1 and 15 symbols.");
                }
                 pizza = new Pizza(pizzaName[1]);

                string[] doughInput = Console.ReadLine().Split(" "/*,StringSplitOptions.RemoveEmptyEntries*/).ToArray();

                string typeOfFlour = doughInput[1];
                string bakingTechnique = doughInput[2];
                double weight = double.Parse(doughInput[3]);

                Dough dough = new Dough(typeOfFlour, bakingTechnique, weight);

                pizza.Dough = dough;

                string[] toppingInput = Console.ReadLine().Split(" "/*, StringSplitOptions.RemoveEmptyEntries*/).ToArray();

                while (toppingInput[0] != "END")
                {
                    
                    string type = toppingInput[1];
                    double weightOfTopping = double.Parse(toppingInput[2]);
                    Topping topping = new Topping(type, weightOfTopping);

                    pizza.AddTopping(topping);     // making my own method and hide the list for proper Encapsulation

                    toppingInput = Console.ReadLine().Split(" "/*, StringSplitOptions.RemoveEmptyEntries*/).ToArray();
                    

                }

                if (toppingInput[0] == "END" && pizza.Toppings.Count == 0)
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
                return;
            }

            Console.WriteLine(pizza);
            
        }
    }
}
