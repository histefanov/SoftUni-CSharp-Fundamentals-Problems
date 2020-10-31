using System;

namespace More_01.Data_type_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "END")
            {

                if (int.TryParse(input, out int integer))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out double floatingPointNumber))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out bool boolean))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (char.TryParse(input, out char character))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
