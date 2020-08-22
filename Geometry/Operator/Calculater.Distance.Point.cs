using Graphic.Component.Geometry.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphic.Component.Geometry.Operator
{
    public static partial class Calculater
    {
        public static double CalculateDistance(Point pt1, Point pt2)
            => CalculateDistance(pt1.X, pt1.Y, pt2.X, pt2.Y);

        public static double CalculateDistance(Point pt, Line line)
        {
            var distnace = Math.Min(
                CalculateDistance(pt, line.Pt1),
                CalculateDistance(pt, line.Pt2));

            return distnace - (line.Width / 2);
        }
    }
}
