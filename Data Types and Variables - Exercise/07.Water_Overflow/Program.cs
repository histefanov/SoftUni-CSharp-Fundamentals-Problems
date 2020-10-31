using System;

namespace _07.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int tankCapacity = 255;

            for (int i = 0; i < lines; i++)
            {
                int waterInput = int.Parse(Console.ReadLine());

                if (tankCapacity >= waterInput)
                {
                    tankCapacity -= waterInput;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(255 - tankCapacity);
        }
    }
}
