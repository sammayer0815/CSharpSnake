using System;

class Program
{
    static void Main()
    {
        int option = 1;

        do
        {
            Console.Clear();
            PrintOptions(option);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    option = Math.Max(1, option - 1);
                    break;

                case ConsoleKey.DownArrow:
                    option = Math.Min(3, option + 1);
                    break;

                case ConsoleKey.Enter:
                    Console.Clear();
                    FinalMenu(option);
                    return;

                default:
                    continue;
            }
        } while (true);
    }

    static void PrintOptions(int selectedOption)
    {
        for (int i = 1; i <= 3; i++)
        {
            if (i == selectedOption)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
            }

            Console.WriteLine($"Option {i}");

            Console.ResetColor();
        }
    }

    static void FinalMenu(int option)
    {
        // Implement your final menu logic here
        Console.WriteLine($"Selected Option is: {option}.");
        Console.ReadLine();
    }
}
