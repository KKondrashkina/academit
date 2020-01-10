using Minesweeper.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MainForm : Form, IView
    {
        public int FieldWidth { get; set; }

        public int FieldHeight { get; set; }

        public int MinesCount { get; set; }

        public int NotFoundMinesCount { get; set; }

        private readonly Presenter presenter;
        private readonly TableLayoutPanel cells;

        private int time = 0;

        public MainForm()
        {
            InitializeComponent();

            timer.Interval = 1000;

            cells = new TableLayoutPanel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Dock = DockStyle.Fill,
                BackColor = SystemColors.ControlDarkDark,
                Margin = new Padding(20, 20, 20, 20)
            };

            cells.MouseDown += Cells_MouseDown;

            field.Controls.Add(cells, 0, 0);

            presenter = new Presenter(this);

            minesCount.Text = Convert.ToString(NotFoundMinesCount);

            CreateField();
        }

        public void NewGame()
        {
            timer.Stop();

            gameTime.Text = "0";

            minesCount.Text = Convert.ToString(NotFoundMinesCount);
        }

        public int EndGame()
        {
            timer.Stop();

            return time;
        }

        public void CreateField()
        {
            MaximumSize = new Size(FieldWidth * 26 + 56, FieldHeight * 26 + 132);
            Size = MaximumSize;

            for (int i = 0; i < FieldWidth; i++)
            {
                cells.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1));
            }

            for (int i = 0; i < FieldHeight; i++)
            {
                cells.RowStyles.Add(new RowStyle(SizeType.Percent, 1));
            }

            for (int i = 0; i < FieldHeight; i++)
            {
                for (int j = 0; j < FieldWidth; j++)
                {
                    Button button = new Button
                    {
                        Margin = new Padding(0),
                        Name = $"button{j}.{i}",
                        Dock = DockStyle.Fill,
                        Text = "",
                        UseVisualStyleBackColor = true,
                        FlatStyle = FlatStyle.Popup,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        BackgroundImage = Resources.ClosedCell
                    };

                    button.MouseDown += Button_MouseDown;

                    cells.Controls.Add(button, j, i);
                }
            }
        }

        public void ClearField()
        {
            cells.Controls.Clear();
        }

        public void PutImageToCell(int x, int y)
        {
            if (presenter.GetCellStatus(x, y).IsOpen)
            {
                cells.Controls.Find($"button{x}.{y}", false)[0].Enabled = false;

                switch (presenter.GetCellStatus(x, y).MinesAroundCount)
                {
                    case 0:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.OpenCell;
                        break;
                    case 1:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Cell1;
                        break;
                    case 2:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Cell2;
                        break;
                    case 3:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Cell3;
                        break;
                    case 4:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Cell4;
                        break;
                    case 5:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Cell5;
                        break;
                    case 6:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Cell6;
                        break;
                    case 7:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Cell7;
                        break;
                    case 8:
                        cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Cell8;
                        break;
                }

                if (presenter.GetCellStatus(x, y).IsMine)
                {
                    cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Mine;
                }
            }
            else
            {
                if (presenter.GetCellStatus(x, y).IsFlag)
                {
                    cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Flag;
                }
                else if (presenter.GetCellStatus(x, y).IsQuestion)
                {
                    cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.Question;
                }
                else
                {
                    cells.Controls.Find($"button{x}.{y}", false)[0].BackgroundImage = Resources.ClosedCell;
                }
            }
        }

        public void ResetTimer()
        {
            time = 0;
            timer.Start();
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            int x = cells.GetCellPosition((Control)sender).Column;
            int y = cells.GetCellPosition((Control)sender).Row;

            timer.Start();

            if (e.Button == MouseButtons.Right)
            {
                presenter.MarkCell(x, y);

                minesCount.Text = Convert.ToString(NotFoundMinesCount);
            }
            else if (e.Button == MouseButtons.Left)
            {
                presenter.OpenCell(x, y);
            }

            PutImageToCell(x, y);
        }

        private void Button_MouseWheel(object sender, MouseEventArgs e)
        {
            int x = cells.GetCellPosition((Control)sender).Column;
            int y = cells.GetCellPosition((Control)sender).Row;

            presenter.OpenNeighboringCells(x, y);

            PutImageToCell(x, y);
        }

        private void Cells_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / (cells.Width / FieldWidth);
            int y = e.Y / (cells.Height / FieldHeight);

            if (e.Button == MouseButtons.Middle)
            {
                presenter.OpenNeighboringCells(x, y);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time++;

            gameTime.Text = Convert.ToString(time);
        }

        private void NewGameMenuItem_Click(object sender, EventArgs e)
        {
            presenter.SetSettings(Settings.Levels.This);
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(presenter);

            settings.ShowDialog();
        }

        private void HighScoresMenuItem_Click(object sender, EventArgs e)
        {
            HighScores highScores = new HighScores();

            highScores.Show();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();

            about.ShowDialog();
        }
    }
}
