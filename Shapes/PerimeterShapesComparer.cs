using Shapes.ShapesClasses;
using System.Collections.Generic;

namespace Shapes
{
    class PerimeterShapesComparer : IComparer<IShape>
    {
        public int Compare(IShape shape1, IShape shape2)
        {
            return shape1.GetPerimeter().CompareTo(shape2.GetPerimeter());
        }
    }
}
