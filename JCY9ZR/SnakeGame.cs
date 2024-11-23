using System;

public class SnakeGame
{
    private int width;
    private int height;

    public SnakeGame(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void Run()
    {
        DrawGameBoard();
    }

    private void DrawGameBoard()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
