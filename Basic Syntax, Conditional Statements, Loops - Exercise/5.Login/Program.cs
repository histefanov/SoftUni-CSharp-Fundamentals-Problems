using System;

namespace _5.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = Console.ReadLine();
            var pass = "";

            for (int i = user.Length - 1; i >= 0; i--)
            {
                pass += user[i];
            }

            for (int i = 0; i < 4; i++)
            {
                if (pass == Console.ReadLine())
                {
                    Console.WriteLine($"User {user} logged in.");
                    return;
                }
                else if (i < 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                } 
                else
                {
                    Console.WriteLine($"User {user} blocked!");
                }
            }
        }
    }
}
