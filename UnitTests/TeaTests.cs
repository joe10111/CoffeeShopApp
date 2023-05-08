using System;
namespace CoffeeShopApp;

	public class TeaTests
	{
        [Fact]
        public void Tests_TeaConstructor()
        {
            Tea JoesTea = new Tea("Green Tea", "Green", true);

            Assert.Equal("Green Tea", JoesTea.NameOfDrink); // Name Of Drink is set to Green Tea
            Assert.Equal("Green", JoesTea.TeaType);      // Tea Type is set to Green
            Assert.True(JoesTea.HotDrink);              // HotDrink is set to true
        }
}


