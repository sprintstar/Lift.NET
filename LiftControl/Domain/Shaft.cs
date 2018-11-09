using System.Collections.Generic;
using LiftControl.Interfaces;

namespace LiftControl.Domain
{
	internal class Shaft : IShaft
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
