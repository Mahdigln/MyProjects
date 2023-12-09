namespace FactoryDesign.Shapes;

public class Circle:IShape
{
    public int Width { get; set; }
    public void Draw()
    {
        Console.WriteLine("Circle Draw()");
    }
}