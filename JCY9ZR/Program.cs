using System;


namespace JCY9ZR
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Loading previous scores...");
                var leaderboard = GameRepository.LoadScores();
                Console.WriteLine("Scores loaded successfully!");

                var game = new SnakeGame(40, 20);
                var finalScore = game.Run();

                GameRepository.SaveScore(new GameState(DateTime.Now, finalScore));
                Console.WriteLine("Score saved successfully!\n");

                Console.WriteLine("Leaderboard:");
                LeaderboardManager.DisplayTopScores(leaderboard, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
