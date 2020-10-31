using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, Product>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productInfo = input.Split();
                string productName = productInfo[0];
                string price = productInfo[1];
                string quantity = productInfo[2];

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, new Product(price, quantity));
                }
                else
                {
                    products[productName].Price = double.Parse(price);
                    products[productName].Quantity += int.Parse(quantity);
                }
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.GetTotalPrice():F2}");
            }
        }

        class Product
        {
            public Product(string price, string quantity)
            {
                Price = double.Parse(price);
                Quantity = int.Parse(quantity);
            }

            public double Price;
            public int Quantity;

            public double GetTotalPrice()
            {
                return this.Price * this.Quantity;
            }
        }
    }
}
