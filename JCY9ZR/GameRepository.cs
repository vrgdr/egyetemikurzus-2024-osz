using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCY9ZR;
using System.IO;
using System.Text.Json;

namespace JCY9ZR
{
    public static class GameRepository
    {
        private const string FilePath = "scores.json";

        public static List<GameState> LoadScores()
        {
            try
            {
                if (!File.Exists(FilePath)) return new List<GameState>();

                var jsonData = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<GameState>>(jsonData) ?? new List<GameState>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading scores: {ex.Message}");
                return new List<GameState>();
            }
        }

        public static void SaveScore(GameState gameState)
        {
            var scores = LoadScores();
            scores.Add(gameState);

            try
            {
                var jsonData = JsonSerializer.Serialize(scores, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(FilePath, jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving score: {ex.Message}");
            }
        }
    }
}

