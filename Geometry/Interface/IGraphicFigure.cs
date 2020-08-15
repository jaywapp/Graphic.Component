namespace Graphic.Component.Geometry.Interface
{
    interface IGraphicFigure : IGraphicComponent, ISizeMeasurable
    {
        bool IsFilled { get; }
    }
}
