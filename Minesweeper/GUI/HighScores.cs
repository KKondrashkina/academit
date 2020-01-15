using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Minesweeper.Logic;

namespace Minesweeper.GUI
{
    public partial class HighScores : Form
    {
        private List<Score> highScoresBeginner = new List<Score>();
        private List<Score> highScoresAmateur = new List<Score>();
        private List<Score> highScoresProfessional = new List<Score>();

        public HighScores()
        {
            InitializeComponent();

            beginner.Checked = true;
        }

        private static void ReadFile(string path, List<Score> highScores)
        {
            using (var reader = new StreamReader(path))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    var result = currentLine.Split('—');

                    highScores.Add(new Score(Convert.ToInt32(result[0]), Convert.ToDateTime(result[1])));
                }
            }
        }

        private static void WriteToFile(string path, Score score)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(Convert.ToString(score.Result) + '—' + score.Date.ToShortDateString());
            }
        }

        private static List<Score> CreateNewHighScores(string path)
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

        private void Beginner_CheckedChanged(object sender, EventArgs e)
        {
            if (beginner.Checked)
            {
                highScoresBeginner = CreateNewHighScores("..\\..\\Resources\\highScoresBeginner.txt");

                for (var i = 0; i < highScoresBeginner.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresBeginner[i].Result) + @" sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresBeginner[i].Date.ToShortDateString();
                }

                for (var i = highScoresBeginner.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = @"—";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                }
            }
        }

        private void Amateur_CheckedChanged(object sender, EventArgs e)
        {
            if (amateur.Checked)
            {
                highScoresAmateur = CreateNewHighScores("..\\..\\Resources\\highScoresAmateur.txt");

                for (var i = 0; i < highScoresAmateur.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresAmateur[i].Result) + @" sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresAmateur[i].Date.ToShortDateString();
                }

                for (var i = highScoresAmateur.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = @"—";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                }
            }
        }

        private void Professional_CheckedChanged(object sender, EventArgs e)
        {
            if (professional.Checked)
            {
                highScoresProfessional = CreateNewHighScores("..\\..\\Resources\\highScoresProfessional.txt");

                for (var i = 0; i < highScoresProfessional.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresProfessional[i].Result) + @" sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresProfessional[i].Date.ToShortDateString();
                }

                for (var i = highScoresProfessional.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = @"—";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                }
            }
        }
    }
}
