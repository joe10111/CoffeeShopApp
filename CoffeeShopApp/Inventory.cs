using System;
namespace CoffeeShopApp
{
	public class Inventory
	{
		public string Name;
		public List<Coffee> AllCoffees;
		public List<Tea> AllTeas;

		public Inventory(string name)
		{
			Name = name;
			AllCoffees = new List<Coffee> { };
			AllTeas = new List<Tea> { };
        }

		public void AddCoffee(Coffee coffeeToAdd)
		{
			AllCoffees.Add(coffeeToAdd);
		}

        public void AddTea(Tea teaToAdd)
        {
            AllTeas.Add(teaToAdd);
        }

		public void DisplayAllDrinks()
		{
			Console.WriteLine("Drink List: ");

			foreach (var coffee in AllCoffees)
			{
				Console.WriteLine(coffee.NameOfDrink);
			}

            foreach (var tea in AllTeas)
            {
                Console.WriteLine(tea.NameOfDrink);
            }
        }
    }
}

