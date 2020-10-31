using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordOccurrences = new Dictionary<string, int>();
            string[] input = Console.ReadLine()
                .Split()
                .Select(i => i.ToLower())
                .ToArray();

            foreach (var item in input)
            {
                if (!wordOccurrences.ContainsKey(item))
                {
                    wordOccurrences.Add(item, 1);
                }
                else
                {
                    wordOccurrences[item]++;
                }
            }

            foreach (var pair in wordOccurrences)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(pair.Key + " ");
                }
            }
        }
    }
}
