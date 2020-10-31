using System;
using System.Collections.Generic;

namespace _05.Softuni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingLot = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    string licensePlateNumber = input[2];

                    if (!parkingLot.ContainsKey(username))
                    {
                        parkingLot.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    if (parkingLot.ContainsKey(username))
                    {
                        parkingLot.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var kvp in parkingLot)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
