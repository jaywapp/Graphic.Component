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

        public bool IsClockWise { get; }
        #endregion

        #region Constructor
        public Curve(
            double x1, double y1, 
            double oriX, double oriY, 
            double x2, double y2, bool isClockWise, double width = 0)
        {
            var radius1 = Calculator.MeasureDistance(x1, y1, oriX, oriY);
            var radius2 = Calculator.MeasureDistance(x2, y2, oriX, oriY);

            if (radius1 != radius2)
                throw new ArgumentException("잘못된 좌표점");

            Pt1 = new Point(x1, y1);
            Pt2 = new Point(x2, y2);
            Origin = new Point(oriX, oriY);
            Width = width;
            Radius = radius1;
            IsClockWise = isClockWise;
        }

        public Curve(Point pt1, Point origin, Point pt2, bool isClockWise, double width = 0)
            : this(pt1.X, pt1.Y, origin.X, origin.Y, pt2.X, pt2.Y, isClockWise, width)
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

            var angle = IsClockWise
                ? Calculator.GetAngle(Pt1, Origin, Pt2)
                : Calculator.GetAngle(Pt2, Origin, Pt1);


            return (2 * Math.PI * Radius) * (angle / 360);
        }
        #endregion
    }
}
