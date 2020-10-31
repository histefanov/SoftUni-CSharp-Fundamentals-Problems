using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split('|')
                .ToArray();

            List<Array> listOfArrays = new List<Array>();

            foreach (var item in arrays)
            {
                listOfArrays.Insert(0, item.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            }

            listOfArrays.ForEach(arr =>
            {
                foreach (var num in arr)
                {
                    Console.Write(num + " ");
                }
            });
        }
    }
}
