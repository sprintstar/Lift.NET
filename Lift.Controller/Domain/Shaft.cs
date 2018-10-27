using Lift.Controller.Interfaces;
using System.Collections.Generic;

namespace Lift.Controller.Domain
{
    internal class Shaft
    {
        public IList<IFloor> Floors { get; }
        public ILift Lift { get; }

        public Shaft(IList<IFloor> floors, ILift lift)
        {
            Floors = floors;
            Lift = lift;
        }
    }
}
