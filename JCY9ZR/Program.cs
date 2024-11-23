class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.CursorVisible = false;

        SnakeGame game = new SnakeGame(40, 20);
        game.Run();
    }
}
