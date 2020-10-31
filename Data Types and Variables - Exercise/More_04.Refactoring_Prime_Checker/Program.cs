using System;

namespace More_04.Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNum = int.Parse(Console.ReadLine());
            for (int i = 2; i <= lastNum; i++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < i; divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, isPrime.ToString().ToLower());
            }
        }
    }
}
