using System;

namespace Minesweeper
{
    class Minefield
    {
        public Cell[,] Cells { get; }

        public int Width { get; }

        public int Height { get; }

        public int MinesCount { get; }

        public Minefield(Settings settings)
        {
            Width = settings.Width;
            Height = settings.Height;
            MinesCount = settings.MinesCount;

            Cells = new Cell[Height, Width];

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Cells[i, j] = new Cell
                    {
                        Y = i,
                        X = j,

                        IsOpen = false
                    };
                }
            }
        }

        public void MineTheField(int cellX, int cellY)
        {
            Random random = new Random();

            int minesCount = 0;

            while (minesCount != MinesCount)
            {
                while (minesCount != MinesCount)
                {
                    int y = random.Next(0, Height);
                    int x = random.Next(0, Width);

                    if (!Cells[y, x].IsMine)
                    {
                        Cells[y, x].IsMine = true;

                        minesCount++;
                    }
                }

                for (int i = -1; i <= 1; i++)
                {
                    if (cellY + i < 0 || cellY + i == Height)
                    {
                        continue;
                    }

                    for (int j = -1; j <= 1; j++)
                    {
                        if (cellX + j < 0 || cellX + j == Width)
                        {
                            continue;
                        }

                        if (Cells[cellY + i, cellX + j].IsMine)
                        {
                            Cells[cellY + i, cellX + j].IsMine = false;

                            minesCount--;
                        }
                    }
                }
            }
        }

        public void SetNumbers()
        {
            int detectedMines = 0;

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (Cells[i, j].IsMine)
                    {
                        detectedMines++;

                        for (int k = -1; k <= 1; k++)
                        {
                            if (i + k < 0 || i + k == Height)
                            {
                                continue;
                            }

                            for (int l = -1; l <= 1; l++)
                            {
                                if (j + l < 0 || j + l == Width)
                                {
                                    continue;
                                }

                                Cells[i + k, j + l].MinesAroundCount++;
                            }
                        }

                        if (detectedMines == MinesCount)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
