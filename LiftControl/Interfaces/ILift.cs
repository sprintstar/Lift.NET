using LiftControl.Enums;
using LiftControl.Model.Statuses;

namespace LiftControl.Interfaces
{
	internal interface ILift
	{
		int DestinationfloorLevel { get; }
		LiftStatus Status { get; }

		LiftStatusReport GetStatusReport();
	}
}
