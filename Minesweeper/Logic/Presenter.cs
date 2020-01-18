using Minesweeper.GUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Minesweeper.Logic
{
    public class Presenter
    {
        private Minefield minefield;
        private Settings settings;
        private readonly HighScores highScores;
        private readonly IView view;
        private bool isFirstClick = true;
        private int closedCells;

        public Presenter(IView view)
        {
            this.view = view;

            settings = new Settings(Settings.Levels.Beginner);
            highScores = new HighScores();

            minefield = new Minefield(settings);

            closedCells = settings.Width * settings.Height;

            view.FieldWidth = minefield.Width;
            view.FieldHeight = minefield.Height;
            view.MinesCount = minefield.MinesCount;

            view.NotFoundMinesCount = view.MinesCount;
        }

        public void StartNewGame()
        {
            isFirstClick = true;

            view.ClearField();

            minefield = new Minefield(settings);

            view.FieldWidth = minefield.Width;
            view.FieldHeight = minefield.Height;
            view.MinesCount = minefield.MinesCount;
            view.NotFoundMinesCount = view.MinesCount;

            view.NewGame();
            view.CreateField();

            closedCells = settings.Width * settings.Height;
        }

        public void EndGame(bool win)
        {
            OpenMinedCells();

            var endGame = new EndGame();

            var time = view.EndGame();

            endGame.SetTime(time);

            endGame.SetGameResult(win);

            var result = endGame.ShowDialog();

            var lastResult = highScores.GetLastResult(settings.Level);

            if (win && settings.Level != Settings.Levels.Special && (lastResult >= time || lastResult == -1))
            {
                var nameForm = new NameForm();
                var name = nameForm.GetName();

                WriteToFile(Convert.ToString(time) + '—' + DateTime.Now.ToShortDateString() + '—' +
                            name, $"..\\..\\Resources\\highScores{settings.Level}.txt");
            }

            if (result == DialogResult.Yes)
            {
                SetSettings(Settings.Levels.This);
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        public List<Score> GetHighScores(Settings.Levels level)
        {
            return highScores.CreateNewHighScores($"..\\..\\Resources\\highScores{level}.txt");
        }

        public void SetSettings(Settings.Levels level)
        {
            if (level != Settings.Levels.This)
            {
                settings = new Settings(level);
            }

            StartNewGame();
        }

        public void SetSettings(int width, int height, int minesCount)
        {
            settings = new Settings(width, height, minesCount);

            StartNewGame();
        }

        public Cell GetCellStatus(int x, int y)
        {
            return minefield.Cells[y, x];
        }

        public int GetCurrentWidth()
        {
            return view.FieldWidth;
        }

        public int GetCurrentHeight()
        {
            return view.FieldHeight;
        }

        public int GetCurrentMinesCount()
        {
            return view.MinesCount;
        }

        public void MarkCell(int x, int y)
        {
            if (minefield.Cells[y, x].IsFlag)
            {
                minefield.Cells[y, x].IsFlag = false;
                minefield.Cells[y, x].IsQuestion = true;

                view.NotFoundMinesCount++;
            }
            else if (minefield.Cells[y, x].IsQuestion)
            {
                minefield.Cells[y, x].IsQuestion = false;
            }
            else
            {
                minefield.Cells[y, x].IsFlag = true;

                view.NotFoundMinesCount--;
            }
        }

        public void OpenCell(int x, int y)
        {
            if (minefield.Cells[y, x].IsFlag)
            {
                return;
            }

            if (minefield.Cells[y, x].MinesAroundCount == 0)
            {
                OpenEmptyCells(x, y);
            }
            else
            {
                OpenOneCell(x, y);
            }
        }

        public void OpenOneCell(int x, int y)
        {
            if (isFirstClick)
            {
                minefield.MineTheField(x, y);
                minefield.SetNumbers();

                view.ResetTimer();

                isFirstClick = false;
            }

            if (!minefield.Cells[y, x].IsOpen)
            {
                minefield.Cells[y, x].IsOpen = true;

                closedCells--;
            }

            view.PutImageToCell(x, y);

            if (minefield.Cells[y, x].IsMine)
            {
                EndGame(false);
            }

            if (closedCells == settings.MinesCount)
            {
                EndGame(true);
            }
        }

        public void OpenNeighboringCells(int x, int y)
        {
            if (minefield.Cells[y, x].MinesAroundCount == 0)
            {
                return;
            }

            var flagsCount = 0;

            var cellsQueue = new Queue<Cell>();

            for (var i = -1; i <= 1; i++)
            {
                if (y + i < 0 || y + i == minefield.Height)
                {
                    continue;
                }

                for (var j = -1; j <= 1; j++)
                {
                    if (x + j < 0 || x + j == minefield.Width)
                    {
                        continue;
                    }

                    if (!minefield.Cells[y + i, x + j].IsOpen)
                    {
                        if (minefield.Cells[y + i, x + j].IsFlag)
                        {
                            flagsCount++;
                        }
                        else
                        {
                            cellsQueue.Enqueue(minefield.Cells[y + i, x + j]);
                        }
                    }
                }
            }

            if (flagsCount == minefield.Cells[y, x].MinesAroundCount)
            {
                foreach (var cell in cellsQueue)
                {
                    OpenCell(cell.X, cell.Y);
                }
            }
        }

        public void OpenMinedCells()
        {
            var openMinedCellsCount = 1;

            for (var i = 0; i < settings.Height; i++)
            {
                for (var j = 0; j < settings.Width; j++)
                {
                    if (minefield.Cells[i, j].IsMine && !minefield.Cells[i, j].IsOpen)
                    {
                        minefield.Cells[i, j].IsOpen = true;

                        view.PutImageToCell(j, i);

                        openMinedCellsCount++;
                    }

                    if (settings.MinesCount == openMinedCellsCount)
                    {
                        return;
                    }
                }
            }
        }

        public void OpenEmptyCells(int x, int y)
        {
            var isVisited = new bool[settings.Height, settings.Width];

            var queue = new Queue<Cell>();

            queue.Enqueue(minefield.Cells[y, x]);

            isVisited[y, x] = true;

            while (queue.Count != 0)
            {
                var currentCell = queue.Dequeue();

                if (!minefield.Cells[currentCell.Y, currentCell.X].IsFlag &&
                    !minefield.Cells[currentCell.Y, currentCell.X].IsOpen)
                {
                    OpenOneCell(currentCell.X, currentCell.Y);
                }

                if (currentCell.MinesAroundCount == 0)
                {
                    for (var k = -1; k <= 1; k++)
                    {
                        if (currentCell.Y + k < 0 || currentCell.Y + k == minefield.Height)
                        {
                            continue;
                        }

                        for (var l = -1; l <= 1; l++)
                        {
                            if (currentCell.X + l < 0 || currentCell.X + l == minefield.Width)
                            {
                                continue;
                            }

                            if (minefield.Cells[currentCell.Y + k, currentCell.X + l].MinesAroundCount != 0 &&
                                !(minefield.Cells[currentCell.Y + k, currentCell.X + l].IsOpen ||
                                minefield.Cells[currentCell.Y + k, currentCell.X + l].IsFlag))
                            {
                                if (!minefield.Cells[currentCell.Y + k, currentCell.X + l].IsFlag)
                                {
                                    OpenOneCell(currentCell.X + l, currentCell.Y + k);
                                }
                            }
                        }
                    }

                    if (currentCell.Y != 0 && !isVisited[currentCell.Y - 1, currentCell.X] &&
                        !isVisited[currentCell.Y - 1, currentCell.X] &&
                        minefield.Cells[currentCell.Y - 1, currentCell.X].MinesAroundCount == 0 &&
                        !(minefield.Cells[currentCell.Y - 1, currentCell.X].IsOpen ||
                        minefield.Cells[currentCell.Y - 1, currentCell.X].IsFlag))
                    {
                        queue.Enqueue(minefield.Cells[currentCell.Y - 1, currentCell.X]);

                        isVisited[currentCell.Y - 1, currentCell.X] = true;
                    }

                    if (currentCell.Y != minefield.Height - 1 && !isVisited[currentCell.Y + 1, currentCell.X] &&
                        minefield.Cells[currentCell.Y + 1, currentCell.X].MinesAroundCount == 0 &&
                        !(minefield.Cells[currentCell.Y + 1, currentCell.X].IsOpen ||
                        minefield.Cells[currentCell.Y + 1, currentCell.X].IsFlag))
                    {
                        queue.Enqueue(minefield.Cells[currentCell.Y + 1, currentCell.X]);

                        isVisited[currentCell.Y + 1, currentCell.X] = true;
                    }

                    if (currentCell.X != 0 && !isVisited[currentCell.Y, currentCell.X - 1] &&
                        minefield.Cells[currentCell.Y, currentCell.X - 1].MinesAroundCount == 0 &&
                        !(minefield.Cells[currentCell.Y, currentCell.X - 1].IsOpen ||
                        minefield.Cells[currentCell.Y, currentCell.X - 1].IsFlag))
                    {
                        queue.Enqueue(minefield.Cells[currentCell.Y, currentCell.X - 1]);

                        isVisited[currentCell.Y, currentCell.X - 1] = true;
                    }

                    if (currentCell.X != minefield.Width - 1 && !isVisited[currentCell.Y, currentCell.X + 1] &&
                        minefield.Cells[currentCell.Y, currentCell.X + 1].MinesAroundCount == 0 &&
                        !(minefield.Cells[currentCell.Y, currentCell.X + 1].IsOpen ||
                        minefield.Cells[currentCell.Y, currentCell.X + 1].IsFlag))
                    {
                        queue.Enqueue(minefield.Cells[currentCell.Y, currentCell.X + 1]);

                        isVisited[currentCell.Y, currentCell.X + 1] = true;
                    }
                }
            }
        }

        private static void WriteToFile(string result, string path)
        {
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine(result);
            }
        }
    }
}
