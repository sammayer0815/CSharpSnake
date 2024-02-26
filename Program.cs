using System;
using System.Diagnostics;

class Program
{
    public static int pos_x = 15;
    public static int pos_y = 15;
    public static int map_width = 25;
    public static int map_height = 25;
    public static int dir = 2;
    public static bool alive = true;
    public static int speed = 100;
    public static int[,] snakePos = {{pos_x, pos_y}};
        
    static void Main()
    {
        Console.Clear();
        drawMap();
        snakeLoop();
    }
    static void snakeLoop()
    {
        while (alive)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        dir = 0;
                        break;
                    case ConsoleKey.A:
                        dir = 1;
                        break;
                    case ConsoleKey.S:
                        dir = 2;
                        break;
                    case ConsoleKey.D:
                        dir = 3;
                        break;
                    default:
                        break;
                }

                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
            }
            drawSnake(dir); 
            deathCheck();
            Thread.Sleep(speed);
        }
    }

    static void drawSnake(int dir)
    {
        Console.SetCursorPosition(pos_x, pos_y);
        Console.Write(" ");
        switch (dir)
        {
            case 0:
                pos_y -= 1;
                break;
            case 1:
                pos_x -= 1;
                break;
            case 2:
                pos_y += 1;
                break;
            case 3:
                pos_x += 1;
                break;
        }
        Console.SetCursorPosition(pos_x, pos_y);
        Console.Write("#");
    }

    static void deathCheck()
    {
        if (pos_x == (map_width - 1) || pos_x == 0)
        {
            death();
        }
        else if (pos_y == (map_height - 1) || pos_y == 0)
        {
            death();
        }
    }

    static void drawMap()
    {
        for (int i = 0; i < (map_height); i++)
        {
            Console.Write("#");
            for (int j = 0; j < (map_width - 2); j++)
            {
                if (i == 0 || i == (map_height - 1))
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.Write("#");
            Console.WriteLine();
        }
    }

    static void death()
    {
        alive = false;
        Console.Clear();
        Console.WriteLine("You died");
    }



































    static void loop()
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