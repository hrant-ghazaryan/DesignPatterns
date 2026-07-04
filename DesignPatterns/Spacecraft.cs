namespace DesignPatterns;

internal class Spacecraft
{
    public string? Name { get; set; }
    public double Mass { get; set; }
    public double Velocity { get; set; }
    public double Position { get; set; }

    public void ApplyThrust(double force, double duration)
    {
        double acceleration = force / Mass;
        Velocity += acceleration * duration;
        Position += Velocity * duration;

        Console.WriteLine($"{Name} accelerated with force {force} for {duration} duration");
    }

    /*public void SaveToDatabase()
    {
        Console.WriteLine($"Spacecraft {Name} saved to database");
    }
    public void SendTelementry()
    {
        Console.WriteLine($"Telementry: {Name}, Pos = {Position}, Vel = {Velocity}");
    }
    public void RenderOnScreen()
    {
        Console.WriteLine($"[Graphics] {Name} at {Position} km, spped {Velocity} m/s");
    }*/
}
