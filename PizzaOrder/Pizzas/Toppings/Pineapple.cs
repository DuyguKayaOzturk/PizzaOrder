using System;
namespace PizzaOrder.Pizzas.Toppings
{
    public class PineappleDecorator : ToppingDecorator
    {
        public PineappleDecorator(Pizza pizza) : base(pizza) { }

        public override decimal Cost()
        {
            return _pizza.Cost() + 10.00m;
        }
    }
}

