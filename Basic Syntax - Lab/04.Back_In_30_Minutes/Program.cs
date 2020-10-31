using System;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var minsAfter = minutes + 30;

            if (minsAfter > 59)
            {
                minsAfter -= 60;
                hours++;
            }

            if (hours > 23)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minsAfter:D2}");
        }
    }
}
