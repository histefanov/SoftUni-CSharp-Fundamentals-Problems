﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometers = meters * 0.001f;
            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
