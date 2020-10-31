using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> numberOccurrences = new SortedDictionary<int, int>();
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var num in numbers)
            {
                if (!numberOccurrences.ContainsKey(num))
                {
                    numberOccurrences.Add(num, 1);
                }
                else
                {
                    numberOccurrences[num]++;
                }
            }

            foreach (var pair in numberOccurrences)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
