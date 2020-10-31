using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deckOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> deckTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (deckOne.Count > 0 && deckTwo.Count > 0)
            {
                int cardOne = deckOne[0];
                int cardTwo = deckTwo[0];
                deckOne.Remove(cardOne);
                deckTwo.Remove(cardTwo);

                if (cardOne > cardTwo)
                {
                    deckOne.Add(cardOne);
                    deckOne.Add(cardTwo);
                }
                else if (cardTwo > cardOne)
                {
                    deckTwo.Add(cardTwo);
                    deckTwo.Add(cardOne);
                }
            }

            if (deckOne.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {deckOne.Aggregate(0, (total, next) => total + next)}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {deckTwo.Aggregate(0, (total, next) => total + next)}");
            }
        }
    }
}
