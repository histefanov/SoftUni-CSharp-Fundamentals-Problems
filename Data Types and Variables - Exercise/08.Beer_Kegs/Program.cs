using System;

namespace _08.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int kegCount = int.Parse(Console.ReadLine());
            double biggestYetVol = 0.0;
            string biggestYetModel = String.Empty;

            for (int i = 0; i < kegCount; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(r, 2) * h;

                if (volume > biggestYetVol)
                {
                    biggestYetModel = model;
                    biggestYetVol = volume;
                }
            }

            Console.WriteLine(biggestYetModel);
        }
    }
}
