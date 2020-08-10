using Graphic.Component.Geometry.Interface;

namespace Graphic.Component.Geometry.Model
{
    public class Straight : IGraphic
    {
        #region Properties
        /// <summary>
        /// Point
        /// </summary>
        public Point Point { get; }
        /// <summary>
        /// 기울기
        /// </summary>
        public double Inclination { get; }
        /// <summary>
        /// 너비
        /// </summary>
        public double Width { get; }
        #endregion
        
        #region Constructor
        public Straight(Point pt, double inclination, double width = 0)
        {
            Point = pt;
            Inclination = inclination;
            Width = width;
        }

        public Straight(double x, double y, double inclination, double width = 0) 
            : this(new Point(x, y), inclination, width)
        {
        }
        #endregion
    }
}
