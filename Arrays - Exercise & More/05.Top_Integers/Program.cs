using System;
using System.Linq;

namespace _05.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string topIntegers = String.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentNum = arr[i];
                bool isTop = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentNum <= arr[j])
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    topIntegers += currentNum + " ";
                }
            }
            topIntegers += arr[^1] + " ";
            Console.WriteLine(topIntegers.Trim());
        }
    }
}
