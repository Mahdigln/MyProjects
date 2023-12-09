namespace FacadePattern.Shapes;

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    public void Draw()
    {
        Console.WriteLine("Rectangle Draw()");
    }
}