namespace DependancyInversion;

internal class RelativisticPhysicsEngine : IPhysicsEngine
{
    public double CalculateAcceleration(double force, double mass)
    {
        double c = 3e8;
        return (force / mass) * 
            (1 / Math.Sqrt(1 + Math.Pow(force / (mass * c), 2))); 
    }
}