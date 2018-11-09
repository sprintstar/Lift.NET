namespace LiftControl.Domain
{
	internal class Floor : IFloor
	{
		public int Level { get; }

		public Floor(int level)
		{
			Level = level;
		}
	}
}
