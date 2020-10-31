using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Merging_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> res = new List<int>();
            int end = Math.Max(first.Count, second.Count);

            for (int i = 0; i < end; i++)
            {
                if (first.Count > i)
                {
                    res.Add(first[i]);
                }
                if (second.Count > i)
                {
                    res.Add(second[i]);
                }
            }
            Console.WriteLine(String.Join(' ', res));
        }
    }
}
