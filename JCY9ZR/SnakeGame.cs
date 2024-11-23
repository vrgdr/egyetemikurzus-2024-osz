using System;

public class SnakeGame
{
    private int width;
    private int height;
    private List<(int X, int Y)> snake;
    private (int X, int Y) fruit;
    private Random random;

    public SnakeGame(int width, int height)
    {
        this.width = width;
        this.height = height;
        snake = new List<(int X, int Y)> { (width / 2, height / 2) };
        random = new Random();
        SpawnFruit();
    }

    private void SpawnFruit()
    {
        fruit = (random.Next(1, width - 1), random.Next(1, height - 1));
    }

    public void Draw()
    {
        Console.Clear();
        for (int x = 0; x <= width; x++)
        {
            Console.SetCursorPosition(x, 0);
            Console.Write("#");
            Console.SetCursorPosition(x, height);
            Console.Write("#");
        }

        for (int y = 0; y <= height; y++)
        {
            Console.SetCursorPosition(0, y);
            Console.Write("#");
            Console.SetCursorPosition(width, y);
            Console.Write("#");
        }
        foreach (var segment in snake)
        {
            Console.SetCursorPosition(segment.X, segment.Y);
            Console.Write("■");
        }
        Console.SetCursorPosition(fruit.X, fruit.Y);
        Console.Write("O");
    }
}
