using System;

namespace _05.Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September",
                               "October", "November", "December" };
            var num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 12)
            {
                Console.WriteLine(months[num - 1]);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
