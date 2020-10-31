using System;
using System.Collections.Generic;

namespace Associative_Arrays___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (!charOccurrences.ContainsKey(input[i]))
                    {
                        charOccurrences.Add(input[i], 1);
                    }
                    else
                    {
                        charOccurrences[input[i]]++;
                    }
                }
            }

            foreach (var kvp in charOccurrences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
