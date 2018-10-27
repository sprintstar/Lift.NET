using Lift.Controller.Enums;
using Lift.Controller.Interfaces;

namespace Lift.Controller.Domain
{
    internal class Lift : ILift
    {
        public int DestinationfloorLevel { get; }
        public LiftStatus Status { get; }

        public Lift()
        {
            DestinationfloorLevel = 0;
            Status = LiftStatus.Stationary;
        }
    }
}
