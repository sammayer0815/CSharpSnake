class Program
{
    static void Main()
    {
        // Clear console to make sure it start at line 0
        Console.Clear();
        // Enables special ascii characters
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Makes UI instance to call the main menu
        UI UIInstance = new();
        UIInstance.MainMenu();
    }

}