using Graphic.Component.Geometry.Interface;
using Graphic.Component.Geometry.Model;
using Microsoft.VisualBasic;

namespace Graphic.Component.Geometry
{
    public class PolygonElement : Point
    {
        public PolygonElement(double x, double y) : base(x, y)
        {
        }
    }

    public static class PolygonElementExt
    {
        public static IGraphicTrace CreateTrace(
            this PolygonElement prev, PolygonElement next)
        {
            if(next is PolygonCurveElement cNext)
                return new Curve(prev, cNext.Center, cNext, cNext.IsClockWise);

            return new Line(prev, next);
        }
    }
}
