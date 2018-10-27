using Lift.Controller.Enums;

namespace Lift.Controller.Interfaces
{
    internal interface ILift
    {
        int DestinationfloorLevel { get; }
        LiftStatus Status { get; }

    }
}
