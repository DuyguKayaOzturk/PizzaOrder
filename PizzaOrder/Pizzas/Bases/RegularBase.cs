using System;
namespace PizzaOrder.Pizzas
{
    public class RegularBase : Pizza
    {
        public string Description { get; protected set; }
        public RegularBase()
        {
            Description = "--- Regular Base ---";
        }

        public decimal Cost()
        {
            return 50.00m;
        }

    }
}
