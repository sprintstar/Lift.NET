using System.Collections.Generic;

namespace LiftControl.Domain
{
	internal interface IShaft
	{
		IList<IFloor> Floors { get; }
		ILift Lift { get; }
	}
}
