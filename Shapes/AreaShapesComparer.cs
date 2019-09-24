﻿using System.Collections.Generic;

namespace Shapes
{
    class AreaShapesComparer : IComparer<IShape>
    {
        public int Compare(IShape shape1, IShape shape2)
        {
            if (shape1.GetArea() > shape2.GetArea())
            {
                return 1;
            }

            if (shape1.GetArea() < shape2.GetArea())
            {
                return -1;
            }

            return 0;
        }
    }
}