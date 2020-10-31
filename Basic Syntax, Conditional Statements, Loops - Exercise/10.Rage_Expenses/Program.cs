using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double rageExpenses = lostGames / 2 * headsetPrice + 
                                  lostGames / 3 * mousePrice +
                                  lostGames / 6 * keyboardPrice +
                                  lostGames / 12 * displayPrice;

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
