using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger bestValueYet = 0;
            int bestQualityYet = 0;
            int bestSnowYet = 0;
            int bestTimeYet = 0;
            
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow(snow / time, quality);

                if (value >= bestValueYet)
                {
                    bestValueYet = value;
                    bestQualityYet = quality;
                    bestSnowYet = snow;
                    bestTimeYet = time;
                }
            }
            Console.WriteLine($"{bestSnowYet} : {bestTimeYet} = {bestValueYet} ({bestQualityYet})");
        }
    }
}
