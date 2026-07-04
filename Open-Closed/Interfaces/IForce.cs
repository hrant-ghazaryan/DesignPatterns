namespace Open_Closed.Interfaces;

internal interface IForce
{
    double Calculate(double mass, double parameter);
    string Name { get; }
}
