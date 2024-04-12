class UI
{
    public void ui(List<Tuple<int, int, string>> options, int optionValue, bool initialDraw)
    {
        if (initialDraw)
        {
            drawCursorPosition(options, optionValue);
        }

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        // Sets default selected option to 1
        int optionsCount = options.Count();

        // Clears option selection symbols
        clearValues(options);

        // Checks user input then switches selected option or enters selected option
        switch (keyInfo.Key)
        {
            case ConsoleKey.W:
                {
                    // Makes it so option cant be lower that 1
                    optionValue = Math.Max(1, optionValue - 1);
                    break;
                }
            case ConsoleKey.S:
                {
                    // Makes it so option cant be higher that optionCount
                    optionValue = Math.Min(optionsCount, optionValue + 1);
                    break;
                }
            case ConsoleKey.Enter:
                {
                    exit(options[optionValue - 1].Item3);
                    break;
                }
            default:
                break;
        }

        drawCursorPosition(options, optionValue);

        ui(options, optionValue, false);
    }

    public void drawCursorPosition(List<Tuple<int, int, string>> options, int optionValue)
    {
        // write code for function that sets the > symbol at correct position 
        int posX = options[optionValue - 1].Item1;
        int posY = options[optionValue - 1].Item2;
        Console.SetCursorPosition(posX, posY);
        Console.Write(">");
        Console.SetCursorPosition(posX, posY);
    }

    public void exit(string selectedOption)
    {
        Console.Clear();

        UI UIInstance = new UI();

        switch (selectedOption)
        {
            case "Play":
                UIInstance.ChooseDifficulty();
                break;
            case "Leaderboard":
                UIInstance.LeaderboardMenu();
                break;
            case "HelpMenu":
                UIInstance.HelpMenu();
                break;
            case "Quit":
                Environment.Exit(0);
                break;
            case "Easy":
                UIInstance.GamePlayMenu("Easy");
                break;
            case "Medium":
                UIInstance.GamePlayMenu("Medium");
                break;
            case "Hard":
                UIInstance.GamePlayMenu("Hard");
                break;
            case "MainMenu":
                UIInstance.MainMenu();
                break;
            case "SubmitScore":
                UIInstance.EnterUsername();
                break;

        }
    }

    static void clearValues(List<Tuple<int, int, string>> options)
    {
        foreach (var option in options)
        {
            Console.SetCursorPosition(option.Item1, option.Item2);
            Console.Write(" ");
        }
    }


    public void MainMenu()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃        _________              __                       ┃");
        Console.WriteLine("┃       /   _____/ ____ _____  |  | __ ____              ┃");
        Console.WriteLine("┃       \\_____  \\ /    \\\\__  \\ |  |/ // __ \\             ┃");
        Console.WriteLine("┃       /        \\   |  \\/ __ \\|    <\\  ___/             ┃");
        Console.WriteLine("┃      /_______  /___|  (____  /__|_ \\\\___  >            ┃");
        Console.WriteLine("┃              \\/     \\/     \\/     \\/    \\/             ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                        Play                            ┃");
        Console.WriteLine("┃                        Leaderboard                     ┃");
        Console.WriteLine("┃                        Help                            ┃");
        Console.WriteLine("┃                        Quit                            ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃              Use WASD keys to navigate.                ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃              Made by:  Sam Maijer                      ┃");
        Console.WriteLine("┃                        Sadek Al Mousawi                ┃");
        Console.WriteLine("┃                        Daniel Pustjens                 ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


        List<Tuple<int, int, string>> options = new List<Tuple<int, int, string>>
        {
            new Tuple<int, int, string>(24, 10, "Play"),
            new Tuple<int, int, string>(24, 11, "Leaderboard"),
            new Tuple<int, int, string>(24, 12, "HelpMenu"),
            new Tuple<int, int, string>(24, 13, "Quit")
        };
        ui(options, 1, true);
    }

    // Back to ?
    public void ChooseDifficulty()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                   Choose Difficulty                    ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                        Easy                            ┃");
        Console.WriteLine("┃                        Medium                          ┃");
        Console.WriteLine("┃                        Hard                            ┃");
        Console.WriteLine("┃                        Go back                         ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


        List<Tuple<int, int, string>> options = new List<Tuple<int, int, string>>
        {
            new Tuple<int, int, string>(24, 8, "Easy"),
            new Tuple<int, int, string>(24, 9, "Medium"),
            new Tuple<int, int, string>(24, 10, "Hard"),
            new Tuple<int, int, string>(24, 11, "MainMenu")
        };
        ui(options, 1, true);
    }

    public void GamePlayMenu(string Difficulty)
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃   Score: 0                                             ┃");
        Console.WriteLine("┃   Time:                                                ┃");
        Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        Snake SnakeInstance = new Snake();

        SnakeInstance.snakeLoop(Difficulty);
    }

    public void DeathMenu(int seconds, int minutes, int score)
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃   _____ _____ _____ _____    _____ _____ _____ _____   ┃");
        Console.WriteLine("┃  |   __|  _  |     |   __|  |     |  |  |   __| __  |  ┃");
        Console.WriteLine("┃  |  |  |     | | | |   __|  |  |  |  |  |   __|    -|  ┃");
        Console.WriteLine("┃  |_____|__|__|_|_|_|_____|  |_____|\\___/|_____|__|__|  ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                        Score:                          ┃");
        Console.WriteLine("┃                        Time:                           ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                         Main menu                      ┃");
        Console.WriteLine("┃                         Submit score                   ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        //Write score
        Console.SetCursorPosition(32, 8);
        Console.WriteLine(score);
        //Write time
        Console.SetCursorPosition(31, 9);
        if (minutes > 0) { Console.Write($"{minutes}:"); }
        Console.WriteLine(seconds);

        List<Tuple<int, int, string>> options = new List<Tuple<int, int, string>>
        {
            new Tuple<int, int, string>(25, 13, "MainMenu"),
            new Tuple<int, int, string>(25, 14, "SubmitScore"),
        };
        ui(options, 1, true);
    }


    public void EnterUsername()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃            Submit name:                                ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃            Max length 8 charters                       ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃            Press enter to confirm.                     ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        writeName();
    }

    public void writeName()
    {
        Console.SetCursorPosition(26, 6);
        string username = Console.ReadLine()!;

        switch (username.Length)
        {
            case var len when len == 0:
                Console.SetCursorPosition(13, 7);
                Console.WriteLine("Name is too short. make it longer");
                Console.SetCursorPosition(26, 6);
                Console.WriteLine("                               ┃");
                writeName();
                break;
            case var len when len > 8:
                Console.SetCursorPosition(13, 7);
                Console.WriteLine("Name is too long. make it shorter");
                Console.SetCursorPosition(26, 6);
                Console.WriteLine("                               ┃");
                writeName();
                break;
            default:
                break;

        }


    }

    public void LeaderboardMenu()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                       Leaderboard                      ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    1.                                                  ┃");
        Console.WriteLine("┃    2.                                                  ┃");
        Console.WriteLine("┃    3.                                                  ┃");
        Console.WriteLine("┃    4.                                                  ┃");
        Console.WriteLine("┃    5.                                                  ┃");
        Console.WriteLine("┃    6.                                                  ┃");
        Console.WriteLine("┃    7.                                                  ┃");
        Console.WriteLine("┃    8.                                                  ┃");
        Console.WriteLine("┃    9.                                                  ┃");
        Console.WriteLine("┃    10.                                                 ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃  Press ESC to return.                                  ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    }

    public void HelpMenu()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                         Help                           ┃");
        Console.WriteLine("┃    How to move:                                        ┃");
        Console.WriteLine("┃    A = Left                                            ┃");
        Console.WriteLine("┃    D = Right                                           ┃");
        Console.WriteLine("┃    W = Up                                              ┃");
        Console.WriteLine("┃    S = Down                                            ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    Score system:                                       ┃");
        Console.WriteLine("┃    @ = 1 point                                         ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    If the number of points is the same                 ┃");
        Console.WriteLine("┃    for multiple users, the shortest time               ┃");
        Console.WriteLine("┃    will determine who gets the highest ranking.        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    When is the game over?                              ┃");
        Console.WriteLine("┃    The game is over when you hit your own tail.        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃     Go back to home                                    ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        List<Tuple<int, int, string>> options = new List<Tuple<int, int, string>>
        {
            new Tuple<int, int, string>(5, 20, "MainMenu"),
        };
        ui(options, 1, true);
    }












}
