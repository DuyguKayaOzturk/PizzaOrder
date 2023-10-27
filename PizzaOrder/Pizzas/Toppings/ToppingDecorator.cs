using System;
namespace PizzaOrder.Pizzas.Toppings
{
	public abstract class ToppingDecorator : Pizza

	{
		protected Pizza _pizza;
		public ToppingDecorator(Pizza pizza)
		{
			_pizza = pizza;
		}

		public virtual string Description => _pizza.Description;
		public abstract decimal Cost();
		
	}
}

