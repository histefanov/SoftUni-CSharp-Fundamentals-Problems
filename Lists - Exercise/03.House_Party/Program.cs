using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string currentGuest = command[0];

                if (!command.Contains("not"))
                {
                    if (!guests.Contains(currentGuest))
                    {
                        guests.Add(currentGuest);
                    }
                    else
                    {
                        Console.WriteLine($"{currentGuest} is already in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(currentGuest))
                    {
                        guests.Remove(currentGuest);
                    }
                    else
                    {
                        Console.WriteLine($"{currentGuest} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
