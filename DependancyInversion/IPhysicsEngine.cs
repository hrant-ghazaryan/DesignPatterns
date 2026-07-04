namespace DependancyInversion;

internal interface IPhysicsEngine
{
    double CalculateAcceleration(double force, double mass);
}
