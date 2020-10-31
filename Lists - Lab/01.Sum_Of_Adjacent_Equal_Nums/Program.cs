using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count - 1;)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] *= 2;
                    numbers.RemoveAt(i + 1);
                    i = Math.Max(i - 1, 0);
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine($"{String.Join(' ', numbers)}");
        }
    }
}
