using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            printNumberSign(int.Parse(Console.ReadLine()));
        }
        static void printNumberSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
