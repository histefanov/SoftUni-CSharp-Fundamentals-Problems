using System;

namespace _03.Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            string file = filePath.Substring(
                filePath.LastIndexOf('\\') + 1, filePath.LastIndexOf('.') - filePath.LastIndexOf('\\') - 1);
            string extension = filePath.Substring(
                filePath.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {file}" + "\n" + $"File extension: {extension}");

        }
    }
}
