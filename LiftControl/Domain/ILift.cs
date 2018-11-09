using LiftControl.Enums;
using LiftControl.Model.Statuses;

namespace LiftControl.Domain
{
	internal interface ILift
	{
		int DestinationfloorLevel { get; }
		LiftStatusEnum Status { get; }

		LiftStatusReport GetStatusReport();
	}
}
