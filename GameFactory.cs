internal static class GameFactory
{
    // Creational pattern: Factory
    internal static UI CreateUI()
    {
        return new UI();
    }

    internal static Snake CreateSnake(string difficulty)
    {
        Snake snake = new Snake();
        snake.SetDifficulty(difficulty);
        return snake;
    }
}
