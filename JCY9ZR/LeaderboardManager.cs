using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCY9ZR
{
    public static class LeaderboardManager
    {
        public static void DisplayTopScores(List<GameState> scores, int topCount)
        {
            var topScores = scores
                .OrderByDescending(s => s.Score)
                .Take(topCount)
                .ToList();

            foreach (var score in topScores)
            {
                Console.WriteLine($"{score.Timestamp:yyyy-MM-dd HH:mm:ss} - Score: {score.Score}");
            }
        }
    }
}
