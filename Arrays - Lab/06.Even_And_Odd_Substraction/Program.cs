using System;
using System.Linq;

namespace _06.Even_And_Odd_Substraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var evenSum = 0;
            var oddSum = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
