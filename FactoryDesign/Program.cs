using FactoryDesign;

try
{
    var circle = ShapeFactory.GetShape(ShapesEnum.CIRCLE);
    circle.Draw();

    var rectangle = ShapeFactory.GetShape(ShapesEnum.RECTANGLE);
    rectangle.Draw();

    var square = ShapeFactory.GetShape(ShapesEnum.SQUARE);
    square.Draw();
}
catch (Exception ex)
{
    throw null;

}
Console.ReadLine();