using System;
using System.Linq;

namespace _06.Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();
            string[] englishSpoken = { "USA", "England" };
            string[] spanishSpoken = { "Spain", "Argentina", "Mexico" };

            if (englishSpoken.Contains(country))
            {
                Console.WriteLine("English");
            }
            else if (spanishSpoken.Contains(country))
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
