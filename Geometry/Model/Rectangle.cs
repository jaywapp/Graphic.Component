using Graphic.Component.Geometry.Interface;
using System;

namespace Graphic.Component.Geometry.Model
{
    public class Rectangle : IGraphicFigure
    {
        #region Properties
        public Point LeftTop { get; }
        public Point LeftBottom { get; }
        public Point RightTop { get; }
        public Point RightBottom { get; }
        public bool IsFilled { get; }
        public double Width => Math.Abs(RightBottom.X - LeftBottom.X);
        public double Height => Math.Abs(RightTop.Y - RightBottom.Y);
        #endregion

        #region Constructor
        public Rectangle(
            Point leftTop, Point leftBottom, 
            Point rightTop, Point rightBottom, 
            bool isFilled = false)
        {
            if (leftTop.X != leftBottom.X)
                throw new ArgumentException();
            if (rightTop.X != rightBottom.X)
                throw new ArgumentException();

            if (leftTop.Y != rightTop.Y)
                throw new ArgumentException();
            if (leftBottom.Y != rightBottom.Y)
                throw new ArgumentException();

            LeftTop = leftTop;
            LeftBottom = leftBottom;
            RightTop = rightTop;
            RightBottom = rightBottom;

            IsFilled = isFilled;
        }

        public Rectangle(Point center, double width, double height, bool isFilled = false)
        {
            var x = width / 2;
            var y = height / 2;

            LeftTop = new Point(center.X - x, center.Y + y);
            RightTop = new Point(center.X + x, center.Y + y);
            LeftBottom = new Point(center.X - x, center.Y - y);
            RightBottom = new Point(center.X + x, center.Y - y);
            IsFilled = isFilled;
        }
        #endregion

        #region Functions
        public double GetAreaSize() => Width * Height;
        #endregion
    }
}
