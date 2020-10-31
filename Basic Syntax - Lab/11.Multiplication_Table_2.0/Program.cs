using System;

namespace _11.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier < 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {multiplier} = {n * multiplier}");
            }
        }
    }
}
