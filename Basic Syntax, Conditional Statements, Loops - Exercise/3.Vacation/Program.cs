using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupCount = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var day = Console.ReadLine();
            var singlePrice = 0.0;
            var totalPrice = 0.0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    singlePrice = 8.45;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 9.80;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 10.46;
                }

                if (groupCount >= 30)
                {
                    totalPrice = singlePrice * groupCount * 0.85;
                }
                else
                {
                    totalPrice = singlePrice * groupCount;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    singlePrice = 10.90;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 15.60;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 16;
                }

                if (groupCount >= 100)
                {
                    totalPrice = (groupCount - 10) * singlePrice;
                }
                else
                {
                    totalPrice = groupCount * singlePrice;
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    singlePrice = 15;
                }
                else if (day == "Saturday")
                {
                    singlePrice = 20;
                }
                else if (day == "Sunday")
                {
                    singlePrice = 22.5;
                }

                if (groupCount >= 10 && groupCount <= 20)
                {
                    totalPrice = groupCount * singlePrice * 0.95;
                }
                else
                {
                    totalPrice = groupCount * singlePrice;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
