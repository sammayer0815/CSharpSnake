using System.Diagnostics;

class UI
{
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
        Console.WriteLine("┃                        Made by                         ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                        Sam                             ┃");
        Console.WriteLine("┃                        Sadek                           ┃");
        Console.WriteLine("┃                        Daniel                          ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
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
        Console.WriteLine("┃                         Easy                           ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                         Medium                         ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                         Hard                           ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    Go back                                             ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    }

    // Back to ?
    public void EnterUsername()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                  Enter your username                   ┃");
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
        Console.WriteLine("┃                         Start                          ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    Go back                                             ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    }

    // TODO: pause menu button in the center
    public void GameplayMenu()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃   Score:                                 ┃   Menu      ┃");
        Console.WriteLine("┃   Time:                                  ┃             ┃");
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
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    }

    public void SubmitTimeMenu()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃   _____ _____ _____ _____    _____ _____ _____ _____   ┃");
        Console.WriteLine("┃  |   __|  _  |     |   __|  |     |  |  |   __| __  |  ┃");
        Console.WriteLine("┃  |  |  |     | | | |   __|  |  |  |  |  |   __|    -|  ┃");
        Console.WriteLine("┃  |_____|__|__|_|_|_|_____|  |_____|\\___/|_____|__|__|  ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    Score:                                              ┃");
        Console.WriteLine("┃    Time:                                               ┃");
        Console.WriteLine("┃    Rank:                                               ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                      Submit time                       ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    }

        public void DeathMenu()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃   _____ _____ _____ _____    _____ _____ _____ _____   ┃");
        Console.WriteLine("┃  |   __|  _  |     |   __|  |     |  |  |   __| __  |  ┃");
        Console.WriteLine("┃  |  |  |     | | | |   __|  |  |  |  |  |   __|    -|  ┃");
        Console.WriteLine("┃  |_____|__|__|_|_|_|_____|  |_____|\\___/|_____|__|__|  ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    Score:                                              ┃");
        Console.WriteLine("┃    Time:                                               ┃");
        Console.WriteLine("┃    Rank:                                               ┃");
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
        Console.WriteLine("┃    Go back to home                      Leaderboard    ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    }

        public void PauseMenu()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                      Pause Menu                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                      Continue                          ┃");
        Console.WriteLine("┃                      Leaderboard                       ┃");
        Console.WriteLine("┃                      Help                              ┃");
        Console.WriteLine("┃                      Return to home                    ┃");
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
    }

    public void LeaderboardMenu()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃                       Leaderboard                      ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
        Console.WriteLine("┃                     Difficulty: Easy                   ┃");
        Console.WriteLine("┣━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┫");
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
        Console.WriteLine("┃    Easy                 Medium                 Hard    ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┃    Go back to home                                     ┃");
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
        Console.WriteLine("┃    Go back to home                                     ┃");
        Console.WriteLine("┃                                                        ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    }

    public void CommitScore()
    {
        Console.WriteLine("┏━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┃                 ┃");
        Console.WriteLine("┗━━━━━━━━━━━━━━━━━┛");
    }

}