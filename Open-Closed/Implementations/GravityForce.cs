using Open_Closed.Interfaces;

namespace Open_Closed.Implementations;

internal class GravityForce : IForce
{
    public string Name => "Gravity";
    public double Calculate(double mass, double parameter)
       =>  mass * 9.81;
}
