using Graphic.Component.Geometry.Interface;
using System;

namespace Graphic.Component.Geometry.Model
{
    public class Circle : IGraphicFigure
    {
        #region Properties
        public Point Center { get; }
        public double Radius { get; }
        public bool IsFilled { get; }
        #endregion

        #region Constructor
        public Circle(Point center, double radius, bool isFilled = false)
        {
            Center = center;
            Radius = radius;
            IsFilled = isFilled;
        }

        public Circle(double x, double y, double radius, bool isFilled = false)
            : this(new Point(x, y), radius, isFilled)
        {
        }
        #endregion

        #region Functions
        public double GetAreaSize() => Math.PI * Radius * Radius;
        #endregion
    }
}
