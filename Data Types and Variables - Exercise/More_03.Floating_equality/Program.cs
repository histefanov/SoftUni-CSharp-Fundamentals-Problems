using System;

namespace More_03.Floating_equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int first = (int)(a / 0.000001);
            int second = (int)(b / 0.000001);

            if (first == second)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
