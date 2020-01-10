using System;

namespace Minesweeper
{
    class Score
    {
        public int Result { get; }

        public DateTime Date { get; }

        public Score(int result, DateTime date)
        {
            Result = result;
            Date = date;
        }
    }
}
