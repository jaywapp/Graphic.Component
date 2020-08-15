using System;

namespace Graphic.Component.Geometry.Operator
{
    public static partial class Calculator
    {
      
        /// <summary>
        /// Pt1, Pt2, Pt3에서 Pt2의 각도를 구합니다.
        /// </summary>
        /// <param name="pt1"></param>
        /// <param name="pt2"></param>
        /// <param name="pt3"></param>
        /// <returns></returns>
        public static double GetAngle(Point pt1, Point pt2, Point pt3)
            => MeasureAngle(pt1.X, pt1.Y, pt2.X, pt2.Y, pt3.X, pt3.Y);
    }
}
