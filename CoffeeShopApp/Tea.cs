using System;
namespace CoffeeShopApp
{
	public class Tea
	{
        public string NameOfDrink;
        public string TeaType;
        public bool HotDrink;

        public Tea(string nameOfDrink, string teaType, bool hotDrink)
		{
			NameOfDrink = nameOfDrink;
			TeaType = teaType;
			HotDrink = hotDrink;
		}
	}
}

