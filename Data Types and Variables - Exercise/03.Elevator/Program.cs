using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int personsCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            //int coursesNeeded = personsCount / elevatorCapacity;
            //if (personsCount % elevatorCapacity != 0)
            //{
            //    coursesNeeded++;
            //}
            //Console.WriteLine(coursesNeeded);
            Console.WriteLine(Math.Ceiling((double)personsCount / elevatorCapacity));
        }
    }
}
