using Graphic.Component.Geometry.Operator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Graphic.Component.Test.Geometry.Operator
{
    [TestFixture]
    public class TestGraphicOperatop
    {
        [TestCase(1, 1, 2, 1, 1)]
        public void TestGetDistance(
            double x1, double y1, double x2, double y2, 
            double expect)
        {
            // when
            var actual = GraphicOperator.GetDistance(x1, y1, x2, y2);

            // then
            Assert.AreEqual(actual, expect);
        }

        [TestCase(1, 0, 0, 0, 0, 1, 90)]
        public void TestGetAngle(
            double x1, double y1, double x2, double y2, double x3, double y3, 
            double expect)
        {
            // when 
            var actual = GraphicOperator.GetAngle(x1, y1, x2, y2, x3, y3);

            // then
            Assert.AreEqual(actual, expect);
        }

    }
}
