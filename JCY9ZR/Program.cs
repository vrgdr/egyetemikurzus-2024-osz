class Program
{
    static void Main(string[] args)
    {
        var game = new SnakeGame(40, 20);
        game.Draw();
        Console.ReadKey();
    }
}
