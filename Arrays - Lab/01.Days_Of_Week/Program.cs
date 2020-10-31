using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", 
                         "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine(n <= 7 && n > 0 ? daysOfWeek[n - 1] : "Invalid day!");
        }
    }
}
