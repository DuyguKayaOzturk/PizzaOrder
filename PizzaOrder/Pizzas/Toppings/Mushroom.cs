using System;
namespace PizzaOrder.Pizzas.Toppings
{
	public class MushroomDecorator : ToppingDecorator
	{
		public MushroomDecorator(Pizza pizza) : base(pizza) { }
       
        public override decimal Cost()
        {
            return _pizza.Cost() + 15.00m;
        }
    }
}

