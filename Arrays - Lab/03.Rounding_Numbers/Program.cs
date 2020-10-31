using System;

namespace _03.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numsAsStrings = Console.ReadLine().Split(" ");
            foreach (var element in numsAsStrings)
            {
                double num = double.Parse(element);

                if (num == 0)
                {
                    num = 0;
                }

                Console.WriteLine(num + " => " + (decimal)Math.Round(num, MidpointRounding.AwayFromZero));
            }
        }
    }
}
