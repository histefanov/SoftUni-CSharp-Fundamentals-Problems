using System;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetBigFactorial(num));
        }

        static BigInteger GetBigFactorial(int num)
        {
            BigInteger factorial = 1;

            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
