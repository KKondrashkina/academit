using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class HighScores : Form
    {
        private List<Score> highScoresBegginer = new List<Score>();
        private List<Score> highScoresAmateur = new List<Score>();
        private List<Score> highScoresProfessional = new List<Score>();

        public HighScores()
        {
            InitializeComponent();

            begginer.Checked = true;
        }

        private void ReadFile(string path, List<Score> highScores)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    string[] result = currentLine.Split('—');

                    highScores.Add(new Score(Convert.ToInt32(result[0]), Convert.ToDateTime(result[1])));
                }
            }
        }

        private void WriteToFile(string path, Score score)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(Convert.ToString(score.Result) + '—' + score.Date.ToShortDateString());
            }
        }

        private List<Score> CreateNewHighScores(string path)
        {
            List<Score> highScores = new List<Score>();

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

        private void Begginer_CheckedChanged(object sender, EventArgs e)
        {
            if (begginer.Checked)
            {
                highScoresBegginer = CreateNewHighScores("highScoresBegginer.txt");

                for (int i = 0; i < highScoresBegginer.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresBegginer[i].Result) + " sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresBegginer[i].Date.ToShortDateString();
                }

                for (int i = highScoresBegginer.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = "—";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                }
            }
        }

        private void Amateur_CheckedChanged(object sender, EventArgs e)
        {
            if (amateur.Checked)
            {
                highScoresAmateur = CreateNewHighScores("highScoresAmateur.txt");

                for (int i = 0; i < highScoresAmateur.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresAmateur[i].Result) + " sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresAmateur[i].Date.ToShortDateString();
                }

                for (int i = highScoresAmateur.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = "—";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                }
            }
        }

        private void Professional_CheckedChanged(object sender, EventArgs e)
        {
            if (professional.Checked)
            {
                highScoresProfessional = CreateNewHighScores("highScoresProfessional.txt");

                for (int i = 0; i < highScoresProfessional.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresProfessional[i].Result) + " sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresProfessional[i].Date.ToShortDateString();
                }

                for (int i = highScoresProfessional.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = "—";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                }
            }
        }
    }
}
