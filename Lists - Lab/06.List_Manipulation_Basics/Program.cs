using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                int n = int.Parse(tokens[1]);

                switch (action)
                {
                    case "Add":
                        numbers.Add(n);
                        break;
                    case "Remove":
                        numbers.Remove(n);
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(n);
                        break;
                    case "Insert":
                        int i = int.Parse(tokens[2]);
                        numbers.Insert(i, n);
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
