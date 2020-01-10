namespace Minesweeper
{
    public class Cell
    {
        public bool IsOpen { get; set; }

        public bool IsMine { get; set; }

        public bool IsFlag { get; set; }

        public bool IsQuestion { get; set; }

        public int MinesAroundCount { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
