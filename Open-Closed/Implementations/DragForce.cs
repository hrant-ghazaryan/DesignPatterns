using Open_Closed.Interfaces;
using System.Reflection.Metadata;

namespace Open_Closed.Implementations
{
    internal class DragForce : IForce
    {
        public string Name => throw new NotImplementedException();

        public double Calculate(double mass, double parameter)
            => 0.5 * parameter * mass;
    }
}
