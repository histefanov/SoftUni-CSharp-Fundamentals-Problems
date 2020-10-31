using System;

namespace _12.Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            bool isEven = false;

            while (!isEven)
            {
                if (num % 2 == 0)
                {
                    isEven = true;
                    Console.WriteLine("The number is: {0}", Math.Abs(num));
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                    num = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
