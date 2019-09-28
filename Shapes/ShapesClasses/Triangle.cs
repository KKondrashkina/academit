using System;

namespace Shapes.ShapesClasses
{
    public class Triangle : IShape
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }
        public double Y1 { get; set; }
        public double Y2 { get; set; }
        public double Y3 { get; set; }

        public Triangle(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            X1 = x1;
            X2 = x2;
            X3 = x3;
            Y1 = y1;
            Y2 = y2;
            Y3 = y3;
        }

        private static double GetSegmentLength(double coordinate1, double coordinate2, double coordinate3, double coordinate4)
        {
            return Math.Sqrt(Math.Pow(coordinate1 - coordinate2, 2) + Math.Pow(coordinate3 - coordinate4, 2));
        }

        public double GetWidth()
        {
            return Math.Max(Math.Max(X1, X2), X3) - Math.Min(Math.Min(X1, X2), X3);
        }

        public double GetHeight()
        {
            return Math.Max(Math.Max(X1, X2), X3) - Math.Min(Math.Min(X1, X2), X3);
        }

        public double GetArea()
        {
            return Math.Abs(0.5 * ((X1 - X3) * (Y2 - Y3) - (X2 - X3) * (Y1 - Y3)));
        }

        public double GetPerimeter()
        {
            return GetSegmentLength(X2, X1, Y2, Y1) + GetSegmentLength(X3, X2, Y3, Y2) + GetSegmentLength(X3, X1, Y3, Y1);
        }

        public override string ToString()
        {
            return "Треугольник" + Environment.NewLine + "С координатами = " + '(' + X1 + ", " + X2 + ", " + X3 +
                "), (" + Y1 + ", " + Y2 + ", " + Y3 + ')' + Environment.NewLine + "Ширина = " + GetWidth() + Environment.NewLine +
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

            Triangle triangle = (Triangle)o;

            return X1 == triangle.X1 && X2 == triangle.X2 && X3 == triangle.X3 && Y1 == triangle.Y1 && Y2 == triangle.Y2 && Y3 == triangle.Y3;
        }

        public override int GetHashCode()
        {
            int prime = 37;
            int hash = 1;

            hash = prime * hash + X1.GetHashCode();
            hash = prime * hash + X2.GetHashCode();
            hash = prime * hash + X3.GetHashCode();
            hash = prime * hash + Y1.GetHashCode();
            hash = prime * hash + Y2.GetHashCode();
            hash = prime * hash + Y3.GetHashCode();

            return hash;
        }
    }
}
