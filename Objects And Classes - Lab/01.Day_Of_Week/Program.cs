using System;
using System.Globalization;

namespace Objects_And_Classes___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
