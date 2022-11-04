
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PizzaCalories
{
    public class Pizza
    {
		private string name;
		private Dough dough;
		private List<Topping> toppings;

		public Pizza(string name)
		{
			this.Name = name;
			this.toppings = new List<Topping>();
			
			
		}

		public string Name
		{
			get { return name; }
			private set
			{
				if (string.IsNullOrWhiteSpace(value) || value.Length > 15) throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");

				this.name = value; 
			}
		}


		public Dough Dough
		{
			get { return dough; }
			set { dough = value; }
		}


		public IReadOnlyCollection<Topping> Toppings
		{
			get { return toppings; }
			private set 
			{
				
				this.toppings = value.ToList();
			}
		}

		public double TotalCalories() 
		{
			double totalCaloriesToppings = Toppings.Sum(t => t.CaloriesPerGram);
			return totalCaloriesToppings + Dough.Calories;
		}

		public void AddTopping(Topping topping)
		{
			toppings.Add(topping);

            if (toppings.Count > 10) throw new ArgumentException("Number of toppings should be in range [0..10].");

        }

		public override string ToString()
		{
			return $"{Name} - {TotalCalories():f2} Calories.";
		}

	}
}
