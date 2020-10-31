using System;

namespace _04.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {            
                    text = text.Replace(word, new String('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
