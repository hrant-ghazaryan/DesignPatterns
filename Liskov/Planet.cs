namespace Liskov;

internal class Planet : CelestrialBody 
{
    public double Radius { get; set; }
    public Planet(double radius)
        => Radius = radius;

    public double GetVolume()
        => (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
}
