namespace FactoryDesign.Shapes;

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public void Draw()
    {
        Console.WriteLine("Rectangle Draw()");
    }
}