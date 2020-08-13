using Graphic.Component.Geometry.Model;
using System;
using System.Numerics;

namespace Graphic.Component.Geometry.Operator
{
    public static class GraphicOperator
    {
        /// <summary>
        /// (x1, y1), (x2, y2) 사이의 거리를 구합니다.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double GetDistance(double x1, double y1, double x2, double y2)
            => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        /// <summary>
        /// pt1, pt2 사이의 거리를 구합니다.
        /// </summary>
        /// <param name="pt1"></param>
        /// <param name="pt2"></param>
        /// <returns></returns>
        public static double GetDistance(Point pt1, Point pt2)
            => GetDistance(pt1.X, pt1.Y, pt2.X, pt2.Y);

        /// <summary>
        /// (x1, y1), (x2, y2), (x3, y3)에서 (x2, y2)의 각도를 구합니다.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>
        /// <returns></returns>
        public static double GetAngle(
            double x1, double y1, double x2, double y2, double x3, double y3)
        {
            var a = GetDistance(x1, y1, x3, y3);
            var b = GetDistance(x1, y1, x2, y2);
            var c = GetDistance(x2, y2, x3, y3);

            var angle = Math.Acos(
                (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c));

            return Math.Round(angle * 180 / Math.PI, 4);
        }
    }
}
