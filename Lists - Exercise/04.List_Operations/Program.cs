using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string operation = string.Empty;
            while ((operation = Console.ReadLine()) != "End")
            {
                string[] tokens = operation.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        numbers.Add(int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        int indexToAdd = int.Parse(tokens[2]);
                        if (indexToAdd >= 0 && indexToAdd < numbers.Count)
                        {
                            numbers.Insert(indexToAdd, int.Parse(tokens[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(tokens[1]);
                        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        if (tokens[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(tokens[2]); i++)
                            {
                                int temp = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(temp);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(tokens[2]); i++)
                            {
                                int temp = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers.Count - 1);
                                numbers.Insert(0, temp);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
