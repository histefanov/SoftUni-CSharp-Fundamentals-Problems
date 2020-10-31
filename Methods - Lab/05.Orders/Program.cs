using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderPriceCalculator(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }

        static void OrderPriceCalculator(string product, int quantity)
        {
            double price = 0.0;
            switch (product)
            {
                case "coffee": price = 1.5; break;
                case "water": price = 1.0; break;
                case "coke": price = 1.4; break;
                case "snacks": price = 2.0; break;
            }
            Console.WriteLine($"{(price * quantity):F2}");
        }
    }
}
