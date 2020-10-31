using System;

namespace _08.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPow(n, pow));
        }

        static double MathPow(double num, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            double res = num;

            for (int i = 1; i < power; i++)
            {
                res *= num;
            }

            return res;
        }
    }
}
