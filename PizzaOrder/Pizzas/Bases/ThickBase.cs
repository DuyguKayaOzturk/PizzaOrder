using System;
namespace PizzaOrder.Pizzas
{
	public class ThickBase : Pizza
	{
		public string Description { get; protected set; }
		public ThickBase()
		{
			Description = "--- Thick Base ---";
		}

		public decimal Cost()
		{
			return 60.00m;
		}
	}
}

