using LiftControl.Enums;
using LiftControl.Model.Statuses;

namespace LiftControl.Domain
{
	internal class Lift : ILift
	{
		public int DestinationfloorLevel { get; }
		public LiftStatusEnum Status { get; }

		public string Name { get; }

		public Lift(string name)
		{
			Name = name;
			DestinationfloorLevel = 0;
			Status = LiftStatusEnum.Stationary;
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
