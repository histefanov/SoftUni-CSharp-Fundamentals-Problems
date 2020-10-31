﻿using System;

namespace _04.Reverse_Array_Of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
