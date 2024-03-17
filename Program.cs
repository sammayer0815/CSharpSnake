class Program
{
    public static int pos_x = 15, pos_y = 15, map_width = 25, map_height = 25, curDir = 2, dir = 2, speed = 100;
    public static bool alive = true;
    public static List<Tuple<int, int>> snakePos = new List<Tuple<int, int>>()
    {
        new Tuple<int, int>(pos_x, pos_y)
    };

    public static Tuple<int, int> applePos;

    static void Main()
    {
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        UI UIInstance = new UI();
        UIInstance.MainMenu();
        // Console.Clear();
        // drawMap();
        // GenerateApple();
        // snakeLoop();
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

                if (Math.Abs(dir - curDir) != 2)
                {
                    curDir = dir;
                }

                // If remove u break game :(, So don't.
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
            }
            drawSnake(curDir);
            deathCheck();
            Thread.Sleep(speed);
        }
    }

    static void drawSnake(int dir)
    {
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

        snakePos.Add(new Tuple<int, int>(pos_x, pos_y));

        // Only do if no apple in next head position
        if (!appleCheck())
        {
            destroyTail();
        }
        else
        {
            GenerateApple();
        }
        drawHead();
    }

    static void drawHead()
    {
        Tuple<int, int> lastPos = snakePos[snakePos.Count - 1];
        Console.SetCursorPosition(lastPos.Item1, lastPos.Item2);
        Console.Write("#");
    }

    static void destroyTail()
    {
        Console.SetCursorPosition(snakePos[0].Item1, snakePos[0].Item2);
        Console.Write(" ");
        snakePos.RemoveAt(0);
    }















    static bool appleCheck()
    {
        Tuple<int, int> lastSnakePos = snakePos[snakePos.Count - 1];
        return lastSnakePos.Item1 == applePos.Item1 && lastSnakePos.Item2 == applePos.Item2;
    }

    static void GenerateApple()
    {
        Random random = new Random();

        while (true)
        {
            int apple_x = random.Next(1, map_width - 1);
            int apple_y = random.Next(1, map_height - 1);

            applePos = new Tuple<int, int>(apple_x, apple_y);

            if (!snakePos.Contains(applePos))
            {
                break;
            }
        }

        Console.SetCursorPosition(applePos.Item1, applePos.Item2);
        Console.Write("@");
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
        else if (snakePos.GetRange(0, snakePos.Count - 1).Contains(snakePos.Last()))
        {
            death();
        }
    }

    static void death()
    {
        alive = false;
        Console.Clear();
        Console.WriteLine("You died");
    }
}