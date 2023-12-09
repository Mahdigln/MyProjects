namespace FactoryDesign.Shapes;

public class Square : IShape
{
    public int Width { get; set; }
    public void Draw()
    {
        Console.WriteLine("Square Draw()");
    }
}