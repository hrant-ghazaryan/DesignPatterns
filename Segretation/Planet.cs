namespace Segretation;

internal class Planet : ICelestialObject
{
    public double Mass { get; set; }
    public double Radius { get; set; }

    public double GetMass() => Mass;
    public double GetRadius() => Radius;

    public double Getluminosity() => throw new NotImplementedException();
    public double GetMagneticFieldStrength() => throw new NotImplementedException();
    public double Temprature() => throw new NotImplementedException();
}
