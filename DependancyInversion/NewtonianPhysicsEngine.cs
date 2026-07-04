namespace DependancyInversion;

internal class NewtonianPhysicsEngine : IPhysicsEngine
{
    public double CalculateAcceleration(double force, double mass)
        => force / mass;
}
