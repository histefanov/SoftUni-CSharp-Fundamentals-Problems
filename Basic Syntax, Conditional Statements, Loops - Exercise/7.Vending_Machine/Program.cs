using System;
using System.Linq;

namespace _7.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] validCoins = { 0.1, 0.2, 0.5, 1, 2 };
            var totalMoney = 0.0;
            var input = Console.ReadLine();
            var coin = 0.0;
            var product = "";
            var price = 0.0;

            while (input != "Start")
            {
                coin = double.Parse(input);

                if (validCoins.Contains(coin))
                {
                    totalMoney += coin;
                } 
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                input = Console.ReadLine();
            }

            product = Console.ReadLine();

            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts": price = 2; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1; break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }

                if (totalMoney - price >= 0)
                {
                    totalMoney -= price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoney:F2}");
        }
    }
}
