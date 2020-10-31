using System;

namespace _9.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lsPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int lightsabers = (int)Math.Ceiling(studentCount * 1.1);
            int robes = studentCount;
            int belts = studentCount - studentCount / 6;
            double totalPrice = lightsabers * lsPrice + robes * robePrice + belts * beltPrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - budget):F2}lv more.");
            }
        }
    }
}
