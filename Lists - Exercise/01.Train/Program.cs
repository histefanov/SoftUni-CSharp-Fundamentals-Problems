using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input.Contains("Add"))
                {
                    wagons.Add(int.Parse(input.Split()[1]));
                }
                else
                {
                    int passengers = int.Parse(input);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= wagonCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
