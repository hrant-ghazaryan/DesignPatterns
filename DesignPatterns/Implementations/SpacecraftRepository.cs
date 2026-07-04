using DesignPatterns.Interfaces;

namespace DesignPatterns.Implementations;

internal class SpacecraftRepository : ISpacecraftRepository
{
    public void Save(Spacecraft spacecraft)
        => Console.WriteLine($"Spacecraft {spacecraft.Name} saved to database");
}
