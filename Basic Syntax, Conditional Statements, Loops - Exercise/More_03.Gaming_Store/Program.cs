using System;

namespace More_03.Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var balance = double.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var gamePrice = 0.0;
            var totalSpent = 0.0;

            while (command != "Game Time")
            {
                switch (command)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        command = Console.ReadLine();
                        continue;                       
                }

                if (balance >= gamePrice)
                {
                    balance -= gamePrice;
                    totalSpent += gamePrice;
                    Console.WriteLine($"Bought {command}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2}");
        }
    }
}
