using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.LINQ_Largest_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numsSorted = nums.OrderByDescending(num => num).Take(3).ToArray();

            Console.WriteLine(string.Join(' ', numsSorted));
        }
    }
}
