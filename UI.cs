class UI
{
    // Function that draws and handels menu selection based on a tuple list
    public void Ui(List<Tuple<int, int, string>> options, int optionValue, bool initialDraw)
    {
        // check if its the first call in the recursion and if so it will set the selected option to option 1
        if (initialDraw)
        {
            // Sets the cursor position at the first option
            DrawCursorPosition(options, optionValue);
        }

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        // Counts how many options there are
        int optionsCount = options.Count;

        // Clears option selection symbols
        ClearValues(options);

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
                    // Selects to selected option
                    Exit(options[optionValue - 1].Item3);
                    break;
                }
            default:
                break;
        }

        // Set cursor at new selected option
        DrawCursorPosition(options, optionValue);
        // Calls the function again with the new selected option
        Ui(options, optionValue, false);
    }

    // Function that draws the > symbol at the correct position
    public void DrawCursorPosition(List<Tuple<int, int, string>> options, int optionValue)
    {
        // write code for function that sets the > symbol at correct position 
        int posX = options[optionValue - 1].Item1;
        int posY = options[optionValue - 1].Item2;
        Console.SetCursorPosition(posX, posY);
        Console.Write(">");
        Console.SetCursorPosition(posX, posY);
    }

    // Function that handles what happens when a option is selected
    public void Exit(string selectedOption)
    {
        Console.Clear();

        UI UIInstance = new();

        switch (selectedOption)
        {
            case "Play":
                UIInstance.ChooseDifficulty();
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
        }
    }

    // Function that clears the > symbol
    static void ClearValues(List<Tuple<int, int, string>> options)
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
        Console.WriteLine("┃                        Help                            ┃");
        Console.WriteLine("┃                        Quit                            ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃              Use WASD keys to navigate.                ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃              Made by:  Sam Maijer                      ┃");
        Console.WriteLine("┃                        Sadek Al Mousawi                ┃");
        Console.WriteLine("┃                        Daniel Pustjens                 ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


        List<Tuple<int, int, string>> options = new()
        {
            new Tuple<int, int, string>(24, 10, "Play"),
            new Tuple<int, int, string>(24, 11, "HelpMenu"),
            new Tuple<int, int, string>(24, 12, "Quit"),
        };
        Ui(options, 1, true);
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


        List<Tuple<int, int, string>> options = new()
        {
            new Tuple<int, int, string>(24, 8, "Easy"),
            new Tuple<int, int, string>(24, 9, "Medium"),
            new Tuple<int, int, string>(24, 10, "Hard"),
            new Tuple<int, int, string>(24, 11, "MainMenu")
        };
        Ui(options, 1, true);
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

        // Starts game loop
        Snake SnakeInstance = new();
        SnakeInstance.SnakeLoop(Difficulty);
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
        Console.WriteLine("┃                         Play again                     ┃");
        Console.WriteLine("┃                         Main menu                      ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

        // Write score
        Console.SetCursorPosition(32, 8);
        Console.WriteLine(score);
        // Write time
        Console.SetCursorPosition(31, 9);
        if (minutes > 0) { Console.Write($"{minutes}:"); }
        Console.WriteLine(seconds);

        List<Tuple<int, int, string>> options = new()
        {
            new Tuple<int, int, string>(25, 13, "Play"),
            new Tuple<int, int, string>(25, 14, "MainMenu"),
        };
        Ui(options, 1, true);
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

        List<Tuple<int, int, string>> options = new()
        {
            new Tuple<int, int, string>(5, 20, "MainMenu"),
        };
        Ui(options, 1, true);
    }
}
