using System;

namespace Minesweeper.Logic
{
    public class Score
    {
        public int Result { get; }

        public DateTime Date { get; }

        public string Name { get; }

        public Score(int result, DateTime date, string name)
        {
            Result = result;
            Date = date;
            Name = name;
        }
    }
}
