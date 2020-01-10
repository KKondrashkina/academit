using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class SettingsForm : Form
    {
        private readonly Presenter presenter;
        private Settings.Levels level;

        public bool IsChangeLevel { get; private set; }

        public SettingsForm(Presenter presenter)
        {
            InitializeComponent();

            this.presenter = presenter;

            width.Text = Convert.ToString(presenter.GetCurrentWidth());
            height.Text = Convert.ToString(presenter.GetCurrentHeight());
            mines.Text = Convert.ToString(presenter.GetCurrentMinesCount());
        }

        private void Begginer_CheckedChanged(object sender, EventArgs e)
        {
            if (begginer.Checked)
            {
                level = Settings.Levels.Begginer;
            }
        }

        private void Amateur_CheckedChanged(object sender, EventArgs e)
        {
            if (amateur.Checked)
            {
                level = Settings.Levels.Amateur;
            }
        }

        private void Professional_CheckedChanged(object sender, EventArgs e)
        {
            if (professional.Checked)
            {
                level = Settings.Levels.Professional;
            }
        }

        private void Special_CheckedChanged(object sender, EventArgs e)
        {
            widthLabel.Visible = !widthLabel.Visible;
            heightLabel.Visible = !heightLabel.Visible;
            minesLabel.Visible = !minesLabel.Visible;

            width.Visible = !width.Visible;
            height.Visible = !height.Visible;
            mines.Visible = !mines.Visible;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (special.Checked)
            {
                presenter.SetSettings(Convert.ToInt32(width.Text), Convert.ToInt32(height.Text), Convert.ToInt32(mines.Text));
            }
            else
            {
                presenter.SetSettings(level);
            }

            Close();
        }

        private void Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                toolTip1.Show("Допустим ввод только чисел.", height, 10000);

                e.Handled = true;
            }
        }

        private void Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                toolTip2.Show("Допустим ввод только чисел.", width, 10000);

                e.Handled = true;
            }
        }

        private void Mines_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                toolTip3.Show("Допустим ввод только чисел.", mines, 10000);

                e.Handled = true;
            }
        }

        private void Height_Leave(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(height.Text);

            if (value < 9)
            {
                height.Text = "9";

                toolTip1.Show("Высота поля может быть не меньше 9.", height, 10000);
            }
            else if (value > 24)
            {
                height.Text = "24";

                toolTip1.Show("Высота поля может быть не больше 24.", height, 10000);
            }
        }

        private void Width_Leave(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(width.Text);

            if (value < 9)
            {
                width.Text = "9";

                toolTip1.Show("Ширина поля может быть не меньше 9.", width, 10000);
            }
            else if (value > 30)
            {
                width.Text = "30";

                toolTip1.Show("Ширина поля может быть не больше 30.", width, 10000);
            }
        }

        private void Mines_Leave(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(mines.Text);
            int maxMinesCount = (int)Math.Ceiling(1.0 / 33 * (31 * Convert.ToInt32(width.Text) * Convert.ToInt32(height.Text) - 300));

            if (value < 10)
            {
                mines.Text = "10";

                toolTip1.Show("Количество мин может быть не меньше 10.", mines, 10000);
            }
            else if (value > maxMinesCount || value > 668)
            {
                mines.Text = Convert.ToString(maxMinesCount);

                toolTip1.Show($"Количество мин может быть не больше {maxMinesCount}.", mines, 10000);
            }
        }
    }
}
