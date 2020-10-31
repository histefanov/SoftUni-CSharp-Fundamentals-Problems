using System;
using System.Linq;

namespace _02.Print_Nums_In_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = n - 1; i > -1; i--)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }
}
