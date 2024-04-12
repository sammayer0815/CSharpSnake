class Snake
{
    public int map_width = 57, map_height = 23, curDir = 2, dir = 2, score = 0, seconds = 0, minutes = 0;
    public static int pos_x = 15, pos_y = 15;
    int speed;
    public bool alive = true;
    public  List<Tuple<int, int>> snakePos = new()
    {
        new Tuple<int, int>(pos_x, pos_y)
    };

    public Tuple<int, int> applePos = new(19, 19);

    private object consoleLock = new();

    public void Timer()
    {
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
        Thread.Sleep(1000);
        if (alive) { Timer(); }
    }

    public void SnakeLoop(string Difficulty)
    {
        //Reset start position
        pos_x = 15; 
        pos_y = 15;
        
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
        // Start thread for timer
        Task.Run(() => Timer());
        Thread.Sleep(100);
        // Generate initial apple
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

                // Makes it so only 1 input can be given per frame (if removed you can add a que of inputs in 1 frame making it so you cant move the snake)
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
            }
            DrawSnake(curDir);
            DeathCheck();
            Thread.Sleep(speed);
        }
    }

    // Draw snake and check if apple is eaten
    public void DrawSnake(int dir)
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
            if (!AppleCheck())
            {
                DestroyTail();
            }
            else
            {
                score++;
                UpdateScore();
                GenerateApple();
            }
            DrawHead();
        }
    }

    public void DrawHead()
    {
        Tuple<int, int> lastPos = snakePos[snakePos.Count - 1];
        Console.SetCursorPosition(lastPos.Item1, lastPos.Item2);
        Console.Write("#");
    }

    public void DestroyTail()
    {
        Console.SetCursorPosition(snakePos[0].Item1, snakePos[0].Item2);
        Console.Write(" ");
        snakePos.RemoveAt(0);
    }

    public bool AppleCheck()
    {
        Tuple<int, int> lastSnakePos = snakePos[snakePos.Count - 1];
        return lastSnakePos.Item1 == applePos.Item1 && lastSnakePos.Item2 == applePos.Item2;
    }

    public void UpdateScore()
    {
        Console.SetCursorPosition(11, 1);
        Console.WriteLine(score);

    }

    public void GenerateApple()
    {
        Random random = new();

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

    public void DeathCheck()
    {
        if (pos_x == (map_width - 1) || pos_x == 0)
        {
            Death();
        }
        else if (pos_y == (map_height - 1) || pos_y == 3)
        {
            Death();
        }
        else if (snakePos.GetRange(0, snakePos.Count - 1).Contains(snakePos.Last()))
        {
            Death();
        }
    }

    public void Death()
    {
        alive = false;
        Console.Clear();
        UI UIInstance = new();
        UIInstance.DeathMenu(seconds, minutes, score);
    }
}