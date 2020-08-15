namespace Graphic.Component.Geometry.Interface
{
    public interface IGraphicTrace : IGraphicComponent, ILengthMeasurable
    {
        /// <summary>
        /// Point1
        /// </summary>
        Point Pt1 { get; }
        /// <summary>
        /// Point2
        /// </summary>
        Point Pt2 { get; }
        /// <summary>
        /// Width
        /// </summary>
        double Width { get; }
    }
}
