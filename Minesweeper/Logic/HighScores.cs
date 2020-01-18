using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Minesweeper.Logic
{
    class HighScores
    {
        private static void ReadFile(string path, List<Score> highScores)
        {
            using (var reader = new StreamReader(path))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    var result = currentLine.Split('—');

                    highScores.Add(new Score(Convert.ToInt32(result[0]), Convert.ToDateTime(result[1]), result[2]));
                }
            }
        }

        private static void WriteToFile(string path, Score score)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(Convert.ToString(score.Result) + '—' + score.Date.ToShortDateString() + '—' + score.Name);
            }
        }

        public int GetLastResult(Settings.Levels level)
        {
            var highScores = CreateNewHighScores($"..\\..\\Resources\\highScores{level}.txt");

            if (highScores.Count < 10)
            {
                return -1;
            }

            return highScores[highScores.Count - 1].Result;
        }

        public List<Score> CreateNewHighScores(string path)
        {
            var highScores = new List<Score>();

            ReadFile(path, highScores);

            if (highScores.Count != 0)
            {
                highScores = highScores
                    .OrderBy(x => x.Result)
                    .Take(10)
                    .ToList();

                File.Delete(path);

                highScores.ForEach(value => WriteToFile(path, value));
            }

            return highScores;
        }
    }
}
