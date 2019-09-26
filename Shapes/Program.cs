using Shapes.ShapesClasses;
using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = { new Square(42.42), new Square(15.7), new Rectangle(11.3, 17.8), new Rectangle(23.4, 45.2), new Circle(36.78),
                new Circle(53.3), new Triangle(2.5, 3.4, 4.3, 9.25, 13.7, 0.54), new Triangle(4.7, 13.3, 4.5, 42.3, 5.5, 7.6) };

            Console.WriteLine("Самая большая площадь = " + FindShapeWithMaxArea(shapes));
            Console.WriteLine("Второй по величине периметр = " + FindShapeWithSecondPerimeter(shapes));

            Console.ReadKey();
        }

        public static IShape FindShapeWithMaxArea(IShape[] shapes)
        {
            Array.Sort(shapes, new AreaShapesComparer());

            return shapes[shapes.Length - 1];
        }

        public static IShape FindShapeWithSecondPerimeter(IShape[] shapes)
        {
            Array.Sort(shapes, new PerimeterShapesComparer());

            return shapes[shapes.Length - 2];
        }
    }
}
