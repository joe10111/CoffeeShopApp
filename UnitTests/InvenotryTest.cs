using System;
namespace CoffeeShopApp;

public class InvenotryTest
{
	[Fact]
	public void Tests_InventoryConstructor()
	{
		Inventory coffeeShopInventory = new Inventory("Joes Coffee Shop");
		Assert.Equal("Joes Coffee Shop", coffeeShopInventory.Name);
	}

    [Fact]
    public void Tests_AddCoffee()
    {
        Inventory coffeeShopInventory = new Inventory("Joes Coffee Shop");
        Coffee JoesCoffee = new Coffee("Latte", "Oat", true);

		coffeeShopInventory.AddCoffee(JoesCoffee);

		Assert.Equal(new List<Coffee> { JoesCoffee },coffeeShopInventory.AllCoffees);
    }

    [Fact]
    public void Tests_AddTea()
    {
        Inventory coffeeShopInventory = new Inventory("Joes Coffee Shop");
        Tea JoesTea = new Tea("Green Tea", "Green", true);

        coffeeShopInventory.AddTea(JoesTea);

        Assert.Equal(new List<Tea> { JoesTea }, coffeeShopInventory.AllTeas);
    }
}


