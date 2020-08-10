using Graphic.Component.Geometry.Interface;
using Graphic.Component.Geometry.Operator;
using System;

namespace Graphic.Component.Geometry.Model
{
    public class Curve : IGraphicTrace
    {
        #region Properties
        /// <summary>
        /// Point1
        /// </summary>
        public Point Pt1 { get; }
        /// <summary>
        /// Point2
        /// </summary>
        public Point Pt2 { get; }
        /// <summary>
        /// Origin
        /// </summary>
        public Point Origin { get; }
        /// <summary>
        /// Width
        /// </summary>
        public double Width { get; }
        /// <summary>
        /// Radius
        /// </summary>
        public double Radius { get; }
        #endregion

        #region Constructor
        public Curve(
            double x1, double y1, 
            double oriX, double oriY, 
            double x2, double y2, double width = 0)
        {
            var radius1 = GraphicOperator.GetDistance(x1, y1, oriX, oriY);
            var radius2 = GraphicOperator.GetDistance(x2, y2, oriX, oriY);

            if (radius1 != radius2)
                throw new ArgumentException("잘못된 좌표점");

            Pt1 = new Point(x1, y1);
            Pt2 = new Point(x2, y2);
            Origin = new Point(oriX, oriY);
            Width = width;
            Radius = radius1;
        }

        public Curve(Point pt1, Point origin, Point pt2, double width = 0)
            : this(pt1.X, pt1.Y, origin.X, origin.Y, pt2.X, pt2.Y, width)
        {
        }
        #endregion

        #region Functions
        /// <summary>
        /// Length 측정
        /// </summary>
        /// <returns></returns>
        public double GetLength()
        {
            var angle = GraphicOperator.GetAngle(
                Pt1.X, Pt1.Y, Origin.X, Origin.Y, Pt2.X, Pt2.Y);

            return (2 * Math.PI * Radius) * (angle / 360);
        }
        #endregion
    }
}
