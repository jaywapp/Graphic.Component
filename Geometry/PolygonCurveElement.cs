namespace Graphic.Component.Geometry
{
    public class PolygonCurveElement : PolygonElement
    {
        public Point Center { get; set; }
        public bool IsClockWise { get; set; }

        public PolygonCurveElement(double x, double y, double xc, double yc, bool isClockwise)
            : base(x, y)
        {
            Center = new Point(xc, yc);
            IsClockWise = isClockwise;
        }

        public PolygonCurveElement(Point pt, Point center, bool isClockwise)
            : this(pt.X, pt.Y, center.X, center.Y, isClockwise)
        {
        }
    }
}
