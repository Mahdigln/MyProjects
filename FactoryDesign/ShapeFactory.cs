using FactoryDesign.Shapes;

namespace FactoryDesign;

public class ShapeFactory
{
    public static IShape GetShape(ShapesEnum shape)
    {
        switch (shape)
        {
            case ShapesEnum.RECTANGLE:
                return new Rectangle();
            case ShapesEnum.SQUARE:
                return new Square();
            case ShapesEnum.CIRCLE:
                return new Circle();
            default:
                return null;
        }
    }
}




