﻿using System;

namespace _07.Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", firstName, delimiter, secondName);
        }
    }
}
