﻿using Shapes.ShapesClasses;
using System.Collections.Generic;

namespace Shapes
{
    class AreaShapesComparer : IComparer<IShape>
    {
        public int Compare(IShape shape1, IShape shape2)
        {
           return shape1.GetArea().CompareTo(shape2.GetArea());
        }
    }
}
