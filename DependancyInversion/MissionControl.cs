namespace DependancyInversion;

internal class MissionControl
{
    private readonly NewtonianPhysicsEngine _engine = new();

    public void ExecuteMisssion(double force, double mass)
    {
        double acceleration = _engine.CalculateAcceleration(force, mass);
        Console.WriteLine($"[MissionControl] Acceleration = {acceleration} m/s");
    }
}
