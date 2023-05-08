namespace CoffeeShopApp;

public class CoffeeTests
{
    [Fact]
    public void Tests_CoffeeConstructor()
    {
        Coffee JoesCoffee = new Coffee("Latte", "Oat", true);

        Assert.Equal("Latte", JoesCoffee.NameOfDrink); // Name Of Drink is set to Latte
        Assert.Equal("Oat", JoesCoffee.MilkType);      // Milk Type is set to Oat
        Assert.True(JoesCoffee.HotDrink);              // HotDrink is set to true
    }
}
