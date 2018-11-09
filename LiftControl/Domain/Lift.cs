using LiftControl.Enums;
using LiftControl.Interfaces;
using LiftControl.Model.Statuses;

namespace LiftControl.Domain
{
	internal class Lift : ILift
	{
		public int DestinationfloorLevel { get; }
		public LiftStatus Status { get; }

		public string Name { get; }

		public Lift(string name)
		{
			Name = name;
			DestinationfloorLevel = 0;
			Status = LiftStatus.Stationary;
		}
		public LiftStatusReport GetStatusReport()
		{
			return new LiftStatusReport()
			{
				LiftIdentification = Name,
				Status = Status
			};
		}
	}
}
