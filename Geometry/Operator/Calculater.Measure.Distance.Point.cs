using Graphic.Component.Geometry.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphic.Component.Geometry.Operator
{
    public static partial class Calculator
    {
        public static double MeasureDistance(Point pt1, Point pt2)
            => MeasureDistance(pt1.X, pt1.Y, pt2.X, pt2.Y);

        public static double MeasureDistance(Point pt, Line line)
        {
            var distnace = Math.Min(
                MeasureDistance(pt, line.Pt1),
                MeasureDistance(pt, line.Pt2));

            return distnace - (line.Width / 2);
        }
    }
}
