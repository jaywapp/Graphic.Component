using Graphic.Component.Geometry.Interface;
using Graphic.Component.Geometry.Operator;

namespace Graphic.Component.Geometry.Model
{
    public class Line : IGraphicTrace
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
        /// Width
        /// </summary>
        public double Width { get; }
        #endregion

        #region Constructor
        public Line(double x1, double y1, double x2, double y2, double width = 0)
        {
            Pt1 = new Point(x1, y1);
            Pt2 = new Point(x2, y2);
            Width = width;
        }

        public Line(Point pt1, Point pt2, double width = 0) 
            : this(pt1.X, pt1.Y, pt2.X, pt2.Y, width)
        {
        }
        #endregion

        #region Function
        /// <summary>
        /// Length 측정
        /// </summary>
        /// <returns></returns>
        public double GetLength() => Calculator.GetDistance(Pt1, Pt2);
        #endregion
    }
}
