using System;
namespace PizzaOrder.Pizzas.Toppings
{
	public class CheeseDecorator : ToppingDecorator
	{
		public CheeseDecorator(Pizza pizza) : base(pizza) { }
		
        public override decimal Cost()
        {
            return _pizza.Cost() + 25.00m;
        }
    }
}

