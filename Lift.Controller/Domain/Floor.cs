using Lift.Controller.Interfaces;

namespace Lift.Controller.Domain
{
    internal class Floor : IFloor 
    {
        public int Level { get; }

        public Floor(int level)
        {
            Level = level;
        }
    }
}
