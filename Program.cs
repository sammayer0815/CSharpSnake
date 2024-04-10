class Program
{
    static void Main()
    {
        DatabaseHelper.InitializeDatabase();
        Console.Clear();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        UI UIInstance = new UI();
        UIInstance.MainMenu();
        // Console.Clear();
        // drawMap();
        // GenerateApple();
        // snakeLoop();
    }

}