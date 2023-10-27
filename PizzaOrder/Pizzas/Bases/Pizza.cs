using System;
namespace PizzaOrder.Pizzas
{
	public interface Pizza
	{
		string Description { get; }
		decimal Cost();
	}
}

