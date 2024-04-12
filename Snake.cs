class Snake
{
    public static int pos_x = 15, pos_y = 15, map_width = 57, map_height = 23, curDir = 2, dir = 2, score = 0, seconds = 0, minutes = 0;
    int speed;
    public static bool alive = true;
    public static List<Tuple<int, int>> snakePos = new List<Tuple<int, int>>()
    {
        new Tuple<int, int>(pos_x, pos_y)
    };

    public static Tuple<int, int> applePos = new Tuple<int, int>(19, 19);

    private static object consoleLock = new object();

    public void timer(int seconds, int minutes)
    {
        Thread.Sleep(1000);
        seconds++;
        if (seconds == 60)
        {
            minutes++;
            seconds = 0;
            lock (consoleLock)
            {
                Console.SetCursorPosition(10, 2);
                Console.WriteLine("               ");
            }
        }
        lock (consoleLock)
        {
            Console.SetCursorPosition(10, 2);
            Console.WriteLine($"{minutes}:{seconds}");
        }
        if (!alive) { timer(seconds, minutes); }
    }

    public void snakeLoop(string Difficulty)
    {
        //Set game speed
        switch (Difficulty)
        {
            case "Easy":
                speed = 400;
                break;
            case "Medium":
                speed = 200;
                break;
            case "Hard":
                speed = 300;
                break;
        }

        Task.Run(() => timer(seconds, minutes));

        GenerateApple();

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

    public void drawSnake(int dir)
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
        lock (consoleLock)
        {
            if (!appleCheck())
            {
                destroyTail();
            }
            else
            {
                score++;
                updateScore();
                GenerateApple();
            }
            drawHead();
        }
    }

    public void drawHead()
    {
        Tuple<int, int> lastPos = snakePos[snakePos.Count - 1];
        Console.SetCursorPosition(lastPos.Item1, lastPos.Item2);
        Console.Write("#");
    }

    public void destroyTail()
    {
        Console.SetCursorPosition(snakePos[0].Item1, snakePos[0].Item2);
        Console.Write(" ");
        snakePos.RemoveAt(0);
    }

    public bool appleCheck()
    {
        Tuple<int, int> lastSnakePos = snakePos[snakePos.Count - 1];
        return lastSnakePos.Item1 == applePos.Item1 && lastSnakePos.Item2 == applePos.Item2;
    }

    public void updateScore()
    {
        Console.SetCursorPosition(11, 1);
        Console.WriteLine(score);

    }

    public void GenerateApple()
    {
        Random random = new Random();

        while (true)
        {
            int apple_x = random.Next(1, map_width - 1);
            int apple_y = random.Next(4, map_height - 1);

            applePos = new Tuple<int, int>(apple_x, apple_y);

            if (!snakePos.Contains(applePos))
            {
                break;
            }
        }

        Console.SetCursorPosition(applePos.Item1, applePos.Item2);
        Console.Write("@");
    }

    public void drawMap()
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

    public void deathCheck()
    {
        if (pos_x == (map_width - 1) || pos_x == 0)
        {
            death();
        }
        else if (pos_y == (map_height - 1) || pos_y == 3)
        {
            death();
        }
        else if (snakePos.GetRange(0, snakePos.Count - 1).Contains(snakePos.Last()))
        {
            death();
        }
    }

    public void death()
    {
        alive = false;
        Console.Clear();
        UI UIInstance = new UI();
        UIInstance.DeathMenu(seconds, minutes, score);
    }
}