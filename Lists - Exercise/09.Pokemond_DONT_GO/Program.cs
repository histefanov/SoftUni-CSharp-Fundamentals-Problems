using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Pokemond_DONT_GO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capturedPokemons = 0;

            while (distances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int value;

                if (index >= 0 && index < distances.Count)
                {
                    value = distances[index];
                    distances.RemoveAt(index);                   
                }
                else if (index < 0)
                {
                    value = distances[0];
                    distances[0] = distances[^1];
                }
                else
                {
                    value = distances[^1];
                    distances[^1] = distances[0];
                }

                distances = distances
                        .Select(e => (e <= value) ? e + value : e - value)
                        .ToList();

                capturedPokemons += value;
            }
            Console.WriteLine(capturedPokemons);
        }
    }
}
