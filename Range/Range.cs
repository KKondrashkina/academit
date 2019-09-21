using System;

namespace Range
{
    class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            double epsilon = 1e-7;

            return number - From >= -epsilon && number - To <= epsilon;
        }

        public Range GetIntersection(Range range)
        {
            if (Math.Max(From, range.From) < Math.Min(To, range.To))
            {
                return new Range(Math.Max(From, range.From), Math.Min(To, range.To));
            }

            return null;
        }

        public Range[] GetUnion(Range range)
        {
            if (Math.Max(From, range.From) <= Math.Min(To, range.To))
            {
                return new Range[] { new Range(Math.Min(From, range.From), Math.Max(To, range.To)) };
            }

            return new Range[] { new Range(From, To), new Range(range.From, range.To) };
        }

        public Range[] GetDifference(Range range)
        {
            if (From > range.To || range.From > To)
            {
                return new Range[] { new Range(From, To) };
            }

            if (From < range.From && range.To < To)
            {
                return new Range[] { new Range(From, range.From), new Range(range.To, To) };
            }

            if (From >= range.From && range.To >= To)
            {
                return new Range[] { };
            }

            if (From >= range.From && To > range.To && From <= range.To)
            {
                return new Range[] { new Range(range.To, To) };
            }

            return new Range[] { new Range(From, range.From) };
        }

        public override string ToString()
        {
            return From + " — " + To;
        }
    }
}
