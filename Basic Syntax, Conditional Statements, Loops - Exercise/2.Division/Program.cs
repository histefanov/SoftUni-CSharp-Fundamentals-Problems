using System;

namespace _2.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] divisors = { 10, 7, 6, 3, 2 };
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 4; i++)
            {
                if (n % divisors[i] == 0)
                {
                    Console.WriteLine("The number is divisible by {0}", divisors[i]);
                    return;
                }
            }

            Console.WriteLine("Not divisible");
        }
    }
}
