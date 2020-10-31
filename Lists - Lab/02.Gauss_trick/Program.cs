using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            if (nums.Count == 1)
            {
                Console.WriteLine(nums[0]);
            }

            double first = 0;
            int last = nums.Count - 1;

            while (first < Math.Ceiling((double)nums.Count / 2)) // 0 1 2 3 4
            {
                nums[(int)first] += nums[last];
                nums.RemoveAt(last);
                first++;
                last--;
            }

            Console.WriteLine(String.Join(' ', nums));
        }
    }
}
