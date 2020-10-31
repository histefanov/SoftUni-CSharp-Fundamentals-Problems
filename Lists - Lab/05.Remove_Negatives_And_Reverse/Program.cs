using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Remove_Negatives_And_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            RemoveNegativeNumbers(nums);
            nums.Reverse();

            if (nums.Count > 0)
            {
                Console.WriteLine(String.Join(' ', nums));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }

        static void RemoveNegativeNumbers(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < 0)
                {
                    nums.RemoveAt(i--);
                }
            }
        }
    }
}
