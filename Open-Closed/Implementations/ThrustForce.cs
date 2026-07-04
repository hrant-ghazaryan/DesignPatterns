using Open_Closed.Interfaces;
using System.Reflection.Metadata;

namespace Open_Closed.Implementations;

internal class ThrustForce : IForce
{
    public string Name => "Thrust";

    public double Calculate(double mass, double parameter)
        => parameter;
}
