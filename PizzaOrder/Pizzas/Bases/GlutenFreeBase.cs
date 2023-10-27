using System;
namespace PizzaOrder.Pizzas
{
	public class GlutenFreeBase : Pizza
	{
        public string Description { get; protected set; }
        public GlutenFreeBase()
		{
			Description = "--- Gluten Free Base ---";
		}

		public decimal Cost()
		{
			return 70.00m;
		}
	}
}

