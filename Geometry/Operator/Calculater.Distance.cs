using Graphic.Component.Geometry.Interface;
using Graphic.Component.Geometry.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphic.Component.Geometry.Operator
{
    public static partial class Calculater
    {
        /// <summary>
        /// (x1, y1), (x2, y2) 사이의 거리를 구합니다.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
            => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}
