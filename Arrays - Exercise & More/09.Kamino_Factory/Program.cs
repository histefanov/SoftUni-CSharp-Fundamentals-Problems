using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int currentLeftmostIndex = int.MaxValue;
            int currentLargestSum = 0;
            int currentLongestSequence = 0;
            int currentBestSample = 1;
            int[] currentBestDna = new int[length];
            int currentSample = 0;

            while (input != "Clone them!")
            {
                int[] dna = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                currentSample++;
                int currentIndex = int.MaxValue;
                int currentSum = dna.Aggregate(0, (sum, next) => sum += next);
                int currentSequence = 0;

                for (int i = 0; i < dna.Length; i++)
                {
                    int temp = 0;

                    if (dna[i] == 1)
                    {
                        temp++;

                        for (int j = i + 1; j < dna.Length; j++)
                        {
                            if (dna[j] == 1)
                            {
                                temp++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (temp > currentSequence)
                        {
                            currentSequence = temp;
                            currentIndex = i;
                        }
                    }
                }

                if (currentSequence > currentLongestSequence)
                {
                    currentBestDna = dna;
                    currentLeftmostIndex = currentIndex;
                    currentLargestSum = currentSum;
                    currentBestSample = currentSample;
                    currentLongestSequence = currentSequence;
                }
                else if (currentSequence == currentLongestSequence)
                {
                    if (currentIndex < currentLeftmostIndex)
                    {
                        currentBestDna = dna;
                        currentLeftmostIndex = currentIndex;
                        currentLargestSum = currentSum;
                        currentBestSample = currentSample;
                        currentLongestSequence = currentSequence;
                    }
                    else if (currentIndex == currentLeftmostIndex)
                    {
                        if (currentSum > currentLargestSum)
                        {
                            currentBestDna = dna;
                            currentLeftmostIndex = currentIndex;
                            currentLargestSum = currentSum;
                            currentBestSample = currentSample;
                            currentLongestSequence = currentSequence;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {currentBestSample} with sum: " +
                $"{currentLargestSum}.\n{String.Join(" ", currentBestDna)}");
        }
    }
}
