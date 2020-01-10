using System.Collections.Generic;

namespace Minesweeper
{
    public class Settings
    {
        public int Width { get; }

        public int Height { get; }

        public int MinesCount { get; }

        public Levels Level { get; }

        private readonly Dictionary<Levels, int[]> levels = new Dictionary<Levels, int[]>()
        {
            {Levels.Begginer, new int[] {9,9,10} },
            {Levels.Amateur, new int[]{16,16,40}},
            {Levels.Professional, new int[]{16,30,99} }
        };

        public Settings(Levels level)
        {
            Level = level;

            Height = levels[level][0];
            Width = levels[level][1];
            MinesCount = levels[level][2];
        }

        public Settings(int width, int height, int minesCount)
        {
            Level = Levels.Special;

            Width = width;
            Height = height;
            MinesCount = minesCount;
        }

        public enum Levels
        {
            Begginer,
            Amateur,
            Professional,
            Special,
            This
        }
    }
}
