using System.Collections.Generic;
using System.Linq;
using LiftControl.Domain;
using LiftControl.Interfaces;
using LiftControl.Model.Statuses;

namespace LiftControl
{
	public class LiftController
	{
		IEnumerable<IShaft> _shafts;

		public LiftController()
		{
			var floors = Enumerable.Range(1, 10).Select(f => new Floor(f) as IFloor).ToList();
			_shafts = new List<IShaft>
			{
				new Shaft(floors, new Lift("Lift 1"))
			};
		}

		public LiftControllerStatus GetStatus()
		{
			return new LiftControllerStatus
			{
				LiftStatuses = _shafts.Select(s => s.Lift.GetStatusReport())
			};
		}
	}
}
