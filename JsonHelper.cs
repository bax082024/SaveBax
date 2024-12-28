using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DodgingGame
{
    public static class JsonHelper
    {
        private static readonly string HighScoreFile = "highscores.json";

        public static List<HighScore> LoadHighScores()
        {
            if (!File.Exists(HighScoreFile)) return new List<HighScore>();

            string json = File.ReadAllText(HighScoreFile);
            return JsonSerializer.Deserialize<List<HighScore>>(json) ?? new List<HighScore>();
        }

        public static void SaveHighScores(List<HighScore> highScores)
        {
            string json = JsonSerializer.Serialize(highScores, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(HighScoreFile, json);
        }
    }
}
