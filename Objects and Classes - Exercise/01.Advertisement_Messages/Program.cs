using System;

namespace _01.Advertisement_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
            string[] authors = { "Diana", "Petya", 
                "Stella", "Elena", "Katya", "Iva", 
                "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", 
                "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < numberOfMessages; i++)
            {
                Console.WriteLine(
                    $"{GetRandomString(phrases)} {GetRandomString(events)} " +
                    $"{GetRandomString(authors)} - {GetRandomString(cities)}");
            }
        }

        static string GetRandomString(string[] arr)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, arr.Length);
            return arr[randomIndex];
        }
    }
}
