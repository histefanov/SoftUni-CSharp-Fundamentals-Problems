using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = input
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = String.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                int n;

                switch (action)
                {
                    case "Contains":
                        int numToCheck = int.Parse(tokens[1]);
                        Console.WriteLine(numbers.Contains(numToCheck) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        List<int> evenNumsFiltered = numbers.FindAll(n => n % 2 == 0);
                        Console.WriteLine(string.Join(' ', evenNumsFiltered));
                        break;
                    case "PrintOdd":
                        List<int> oddNumsFiltered = numbers.FindAll(n => n % 2 != 0);
                        Console.WriteLine(string.Join(' ', oddNumsFiltered));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Aggregate(0, (total, next) => total + next));
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int numToCompareWith = int.Parse(tokens[2]);

                        if (condition == "<")
                        {
                            IEnumerable<int> numbersFiltered = numbers.Where(n => n < numToCompareWith);
                            Console.WriteLine(string.Join(' ', numbersFiltered));
                        }
                        else if (condition == ">")
                        {
                            IEnumerable<int> numbersFiltered = numbers.Where(n => n > numToCompareWith);
                            Console.WriteLine(string.Join(' ', numbersFiltered));
                        }
                        else if (condition == "<=")
                        {
                            IEnumerable<int> numbersFiltered = numbers.Where(n => n <= numToCompareWith);
                            Console.WriteLine(string.Join(' ', numbersFiltered));
                        }
                        else if (condition == ">=")
                        {
                            IEnumerable<int> numbersFiltered = numbers.Where(n => n >= numToCompareWith);
                            Console.WriteLine(string.Join(' ', numbersFiltered));
                        }
                        break;
                    case "Add":
                        n = int.Parse(tokens[1]);
                        numbers.Add(n);
                        break;
                    case "Remove":
                        n = int.Parse(tokens[1]);
                        numbers.Remove(n);
                        break;
                    case "RemoveAt":
                        n = int.Parse(tokens[1]);
                        numbers.RemoveAt(n);
                        break;
                    case "Insert":
                        int i = int.Parse(tokens[2]);
                        n = int.Parse(tokens[1]);
                        numbers.Insert(i, n);
                        break;
                }
            }
            if (string.Join(' ', numbers).CompareTo(input) != 0)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
