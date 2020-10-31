using System;
using System.Collections.Generic;

namespace _03.Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordSynonyms = new Dictionary<string, List<string>>();
            int wordsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (wordSynonyms.ContainsKey(word))
                {
                    wordSynonyms[word].Add(synonym);
                }
                else
                {
                    wordSynonyms.Add(word, new List<string>() { synonym });
                }
            }

            foreach (var pair in wordSynonyms)
            {
                Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
            }
        }
    }
}
