namespace Liskov;

internal class InvalidShape : IShape
{
    public double Area => -1;
    public double Perimetr => -5;
}
