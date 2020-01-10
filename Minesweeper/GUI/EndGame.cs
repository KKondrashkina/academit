using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class EndGame : Form
    {
        private int time;

        public EndGame()
        {
            InitializeComponent();
        }

        public void SetTime(int time)
        {
            this.time = time;
        }

        public void SetGameResult(bool result)
        {
            if (result)
            {
                this.result.Text = "You win!";
            }
            else
            {
                this.result.Text = "You lose!";
            }
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            gameTime.Text = $"Game time: {time} seconds.";
        }

        private void EndGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DialogResult != DialogResult.No)
            {
                DialogResult = DialogResult.Yes;
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
