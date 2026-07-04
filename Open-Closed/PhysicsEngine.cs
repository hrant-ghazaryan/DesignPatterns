namespace Open_Closed;

internal class PhysicsEngine
{
    public double CalculateForce(string forceType,
        double mass, double parametr)
    {
        return forceType switch
        {
            "Gravity" => mass * 9.81,
            "Thrust" => parametr,
            "Drag" => 0.5 * parametr * mass,
            _ => throw new Exception("Unknown force type"),
        };
    }
}