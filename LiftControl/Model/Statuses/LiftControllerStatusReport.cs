using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiftControl.Model.Statuses
{
	public class LiftControllerStatus
	{
		public IEnumerable<LiftStatusReport> LiftStatuses { get; set; }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"{LiftStatuses.Count()} lift(s):");

			foreach(var liftStatus in LiftStatuses)
			{
				sb.AppendLine(liftStatus.ToString());
			}

			return sb.ToString();
		}
	}
}
