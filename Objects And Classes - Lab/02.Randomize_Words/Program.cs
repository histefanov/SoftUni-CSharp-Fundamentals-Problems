using System;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                int index = rnd.Next(i, arr.Length);
                string temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
            }

            foreach (var word in arr)
            {
                Console.WriteLine(word);
            }
        }
    }
}
