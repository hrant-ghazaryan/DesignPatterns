namespace Liskov;

internal class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area => Width * Height;
    public double Perimetr => 2 * (Width * Height);
}
