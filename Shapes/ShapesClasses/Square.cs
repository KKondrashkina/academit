using System;

namespace Shapes.ShapesClasses
{
    public class Square : IShape
    {
        public double Length { get; set; }

        public Square(double length)
        {
            Length = length;
        }

        public double GetWidth()
        {
            return Length;
        }

        public double GetHeight()
        {
            return Length;
        }

        public double GetArea()
        {
            return Math.Pow(Length, 2);
        }

        public double GetPerimeter()
        {
            return Length * 4;
        }

        public override string ToString()
        {
            return "Квадрат" + Environment.NewLine + "Длина стороны = " + Length + "Ширина = " + GetWidth() + Environment.NewLine +
                "Высота = " + GetHeight() + Environment.NewLine + "Площадь = " + GetArea() + Environment.NewLine + "Периметр = " + GetPerimeter();
        }

        public override bool Equals(object o)
        {
            if (ReferenceEquals(o, this))
            {
                return true;
            }

            if (ReferenceEquals(o, null) || o.GetType() != GetType())
            {
                return false;
            }

            Square square = (Square)o;

            return Length == square.Length;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + Length.GetHashCode();

            return hash;
        }
    }
}
