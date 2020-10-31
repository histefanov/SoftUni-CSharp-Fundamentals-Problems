using System;

namespace _10.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCounter = 0;
            int pokePower = startingPokePower;

            while (pokePower >= distance)
            {
                pokeCounter++;
                pokePower -= distance;

                if (pokePower == 0.5 * startingPokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine($"{pokePower}\n{pokeCounter}");
        }
    }
}
