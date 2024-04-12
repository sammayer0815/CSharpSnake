class Program
{
    static void Main()
    {
        // We have tested my code extensivly and have not found any errors which is why I only have this try catch + in my timer for any exceptions that might occur
        try
        {
            // Clear console to make sure it start at line 0
            Console.Clear();
            // Enables special ascii characters
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Makes UI instance to call the main menu
            UI UIInstance = new();
            UIInstance.MainMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message} restarting in 5 seconds...");
            Thread.Sleep(5000);
            Main();
        }
    }

}