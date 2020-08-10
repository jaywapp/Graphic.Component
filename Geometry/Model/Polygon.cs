using Graphic.Component.Geometry.Interface;
using System;
using System.Collections.Generic;

namespace Graphic.Component.Geometry.Model
{
    public class Polygon : IGraphicFigure
    {
        public List<PolygonElement> Elements { get; set; }

        public bool IsFilled => throw new NotImplementedException();

        public double GetAreaSize()
        {
            throw new NotImplementedException();
        }
    }
}
