internal class ConsoleFacade
{
    private readonly object _consoleLock;

    public ConsoleFacade(object consoleLock)
    {
        _consoleLock = consoleLock;
    }

    public void WriteAt(int x, int y, string text)
    {
        lock (_consoleLock)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
    }

    public void WriteLineAt(int x, int y, string text)
    {
        lock (_consoleLock)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
        }
    }

    public void ClearAt(int x, int y, int length)
    {
        lock (_consoleLock)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', length));
        }
    }
}
