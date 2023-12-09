using FacadePattern.Shapes;


namespace FacadePattern;

public class ShapeFactory
{
    private Circle circle;
    private Square square;
    private Rectangle rectangle;

    public ShapeFactory()
    {
        circle = new Circle();
        square = new Square();
        rectangle = new Rectangle();
    }

    public Circle GetCircle()
    {
        return circle;
    }
    public Square GetSquare()
    {
        return square;
    }
    public Rectangle GetRectangle()
    {
        return rectangle;
    }
}