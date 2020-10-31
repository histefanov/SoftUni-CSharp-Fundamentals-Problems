using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] train = new int[wagonsCount];
            int allPassengers = 0;

            for (int i = 0; i < wagonsCount; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                train[i] = passengers;
                allPassengers += passengers;
            }

            Console.WriteLine($"{String.Join(" ", train)}\n{allPassengers}");

        }
    }
}
