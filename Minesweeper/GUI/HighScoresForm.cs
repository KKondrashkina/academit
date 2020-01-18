using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Minesweeper.Logic;

namespace Minesweeper.GUI
{
    public partial class HighScoresForm : Form
    {
        private readonly List<Score> highScoresBeginner;
        private readonly List<Score> highScoresAmateur;
        private readonly List<Score> highScoresProfessional;

        public HighScoresForm(Presenter presenter)
        {
            InitializeComponent();

            highScoresBeginner = presenter.GetHighScores(Settings.Levels.Beginner);
            highScoresAmateur = presenter.GetHighScores(Settings.Levels.Amateur);
            highScoresProfessional = presenter.GetHighScores(Settings.Levels.Professional);

            beginner.Checked = true;
        }

        private void Beginner_CheckedChanged(object sender, EventArgs e)
        {
            if (beginner.Checked)
            {
                for (var i = 0; i < highScoresBeginner.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresBeginner[i].Result) + " sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresBeginner[i].Date.ToShortDateString();

                    highScoresTable.Controls.Find($"name{i}", false)[0].Text =
                        highScoresBeginner[i].Name;
                }

                for (var i = highScoresBeginner.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = "";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                    highScoresTable.Controls.Find($"name{i}", false)[0].Text = "—";
                }
            }
        }

        private void Amateur_CheckedChanged(object sender, EventArgs e)
        {
            if (amateur.Checked)
            {
                for (var i = 0; i < highScoresAmateur.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresAmateur[i].Result) + " sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresAmateur[i].Date.ToShortDateString();

                    highScoresTable.Controls.Find($"name{i}", false)[0].Text =
                        highScoresAmateur[i].Name;
                }

                for (var i = highScoresAmateur.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = "";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                    highScoresTable.Controls.Find($"name{i}", false)[0].Text = "—";
                }
            }
        }

        private void Professional_CheckedChanged(object sender, EventArgs e)
        {
            if (professional.Checked)
            {
                for (var i = 0; i < highScoresProfessional.Count; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text =
                        Convert.ToString(highScoresProfessional[i].Result) + " sec.";

                    highScoresTable.Controls.Find($"date{i}", false)[0].Text =
                        highScoresProfessional[i].Date.ToShortDateString();

                    highScoresTable.Controls.Find($"name{i}", false)[0].Text =
                        highScoresProfessional[i].Name;
                }

                for (var i = highScoresProfessional.Count; i < 10; i++)
                {
                    highScoresTable.Controls.Find($"gameTime{i}", false)[0].Text = "";
                    highScoresTable.Controls.Find($"date{i}", false)[0].Text = "";
                    highScoresTable.Controls.Find($"name{i}", false)[0].Text = "—";
                }
            }
        }
    }
}
