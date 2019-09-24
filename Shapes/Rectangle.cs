using System;

namespace Shapes
{
    public class Rectangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public double GetWidth()
        {
            return Math.Min(Side1, Side2);
        }

        public double GetHeight()
        {
            return Math.Max(Side1, Side2);
        }

        public double GetArea()
        {
            return Side1 * Side2;
        }

        public double GetPerimeter()
        {
            return 2 * Side1 + 2 * Side2;
        }

        public override string ToString()
        {
            return "Прямоугольник" + Environment.NewLine + "Сторона 1 = " + Side1 + "Сторона 2 = " + Side2 + Environment.NewLine +
                "Ширина = " + GetWidth() + Environment.NewLine + "Высота = " + GetHeight() + Environment.NewLine + "Площадь = " + GetArea() +
                Environment.NewLine + "Периметр = " + GetPerimeter();
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

            Rectangle rectangle = (Rectangle)o;

            return Side1 == rectangle.Side1 && Side2 == rectangle.Side2;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + Side1.GetHashCode();
            hash = prime * hash + Side2.GetHashCode();

            return hash;
        }
    }
}
