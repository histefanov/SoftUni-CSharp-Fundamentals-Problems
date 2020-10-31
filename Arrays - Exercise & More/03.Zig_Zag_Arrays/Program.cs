using System;

namespace _03.Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arrOne = new string[n];
            string[] arrTwo = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentNums = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    arrOne[i] = currentNums[0];
                    arrTwo[i] = currentNums[1];
                }
                else
                {
                    arrOne[i] = currentNums[1];
                    arrTwo[i] = currentNums[0];
                }
            }
            Console.WriteLine($"{String.Join(" ", arrOne)}\n{String.Join(" ", arrTwo)}");
        }
    }
}
