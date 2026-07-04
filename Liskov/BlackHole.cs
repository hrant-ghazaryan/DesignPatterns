namespace Liskov;

internal class BlackHole : CelestrialBody
{
    public double Mass { get; set; }
    public BlackHole(double mass)
        => Mass = mass;
}
