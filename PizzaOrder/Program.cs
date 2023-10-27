using System;
using System.Collections.Generic;
using PizzaOrder;
using PizzaOrder.Pizzas;
using PizzaOrder.Pizzas.Toppings;

class Program
{
    static void Main(string[] args)
    {
        List<Pizza> basePizzas = new List<Pizza>();
        basePizzas.Add(new RegularBase());
        basePizzas.Add(new GlutenFreeBase());
        basePizzas.Add(new ThickBase());

        Random random = new Random();

        for (int i = 0; i < 3; i++) // It will loop 3 times to create 3 different pizzas
        {
            int randomIndex = random.Next(basePizzas.Count); // Selects a random pizza base
            Pizza basePizza = basePizzas[randomIndex]; // Gets the selected pizza base

            Pizza pizza = basePizza;

            // While adding pizza components, it prints the name and price
            Console.WriteLine($"Pizza {i + 1}:");
            Console.WriteLine($"{basePizza.Description}");
            Console.WriteLine();

            pizza = new CheeseDecorator(pizza);
            Console.WriteLine($" + cheese");
            pizza = new MushroomDecorator(pizza);
            Console.WriteLine($" + mushrooms");
            pizza = new PineappleDecorator(pizza);
            Console.WriteLine($" + pineapple(iyyk,really!!!)");
            pizza = new HamDecorator(pizza);
            Console.WriteLine($" + ham");
            pizza = new BananaDecorator(pizza);
            Console.WriteLine($" + banana(iykk,really!!!)");

            // Total Price
            decimal totalPrice = pizza.Cost();
            Console.WriteLine($"Price {totalPrice:C}");
            Console.WriteLine();
        }
    }
}
