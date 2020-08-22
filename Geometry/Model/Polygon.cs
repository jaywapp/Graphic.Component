using Graphic.Component.Geometry.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphic.Component.Geometry.Model
{
    public class Polygon : IGraphicFigure
    {
        public List<PolygonElement> Elements { get; set; }

        public Polygon(params PolygonElement[] elements)
        {
            Elements = elements.ToList();
        }

        public bool IsFilled { get; set; }

        public double GetAreaSize()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IGraphicTrace> GetTraces()
        {
            foreach(var elememt in Elements)
            {
                var idx = Elements.IndexOf(elememt);

                if (Elements.Count - 1 == idx)
                    break;

                var next = Elements[idx + 1];

                yield return elememt.CreateTrace(next);
            }

            yield return Elements.Last()
                .CreateTrace(Elements.First());
        }
    }
}
