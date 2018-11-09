using System.Collections.Generic;

namespace LiftControl.Interfaces
{
	internal interface IShaft
	{
		IList<IFloor> Floors { get; }
		ILift Lift { get; }
	}
}
