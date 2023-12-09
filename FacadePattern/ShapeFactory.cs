using FacadePattern.Shapes;


namespace FacadePattern;

public class ShapeFactory
{
    
    public void Draw()
    {
        var Circle = new Circle();
        var square = new Square();
        var rectangle = new Rectangle();


        Circle.Draw();
        square.Draw();
        rectangle.Draw();
    }
   
}