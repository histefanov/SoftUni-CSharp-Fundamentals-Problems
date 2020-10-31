using System;

namespace _09.Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyYield = int.Parse(Console.ReadLine());
            int totalYield = 0;
            int dayCounter = 0;

            while (dailyYield >= 100)
            {
                totalYield += dailyYield - 26;
                dailyYield -= 10;
                dayCounter++;
            }

            totalYield -= 26;
            Console.WriteLine("{0}\n{1}", dayCounter, Math.Max(0, totalYield));
        }
    }
}
