﻿using LiftControl.Enums;

namespace LiftControl.Model.Statuses
{
	public class LiftStatusReport
	{
		public string LiftIdentification { get; set; }
		public LiftStatus Status { get; set; }

		public override string ToString()
		{
			return $"{LiftIdentification} - {Status}";
		}
	}
}
