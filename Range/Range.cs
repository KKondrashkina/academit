using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Range
    {
        public double From
        {
            get;
            set;
        }

        public double To
        {
            get;
            set;
        }

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
            if (From >= range.To || range.From >= To)
            {
                return null;
            }

            if (From <= range.From && range.To <= To)
            {
                return new Range(range.From, range.To);
            }

            if (From > range.From && range.To > To)
            {
                return new Range(From, To);
            }

            if (From > range.From && To > range.To && From < range.To)
            {
                return new Range(From, range.To);
            }

            return new Range(range.From, To);
        }

        public Range[] GetUnion(Range range)
        {
            if (From > range.To || range.From > To)
            {
                return new Range[] { new Range(From, To), new Range(range.From, range.To) };
            }

            if (From <= range.From && range.To <= To)
            {
                return new Range[] { new Range(From, To) };
            }

            if (From > range.From && range.To > To)
            {
                return new Range[] { new Range(range.From, range.To) };
            }

            if (From > range.From && To > range.To && From <= range.To)
            {
                return new Range[] { new Range(range.From, To) };
            }

            return new Range[] { new Range(From, range.To) };
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
