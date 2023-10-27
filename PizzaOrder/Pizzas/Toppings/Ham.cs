using System;
namespace PizzaOrder.Pizzas.Toppings
{
	public class HamDecorator : ToppingDecorator
	{
		public HamDecorator(Pizza pizza) : base(pizza) { }

        public override decimal Cost()
        {
            return _pizza.Cost() + 20.00m;
        }
    }
}

