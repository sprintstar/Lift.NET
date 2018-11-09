using LiftControl.Domain;
using LiftControl.Domain.Events;
using LiftControl.Model.Statuses;
using log4net;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LiftControl
{
	public class LiftController
	{
		private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		private readonly IEnumerable<IShaft> _shafts;

		public LiftController()
		{
			_log.Info("LiftController created");

			// Create lifts, floors and shafts
			var floors = Enumerable.Range(1, 10).Select(f => new Floor(f) as IFloor).ToList();
			_shafts = new List<IShaft>
			{
				new Shaft(floors, new Lift("Lift 1"))
			};
		}

		// Needs a listener for button presses.  Should present an interface into which events can be passed.
		// for example, events can come from button presses on floors, and button presses in the list
		// need an event input pipeline, and a list of events that can be added
		public void AddEvent(IEvent eventObject)
		{
			
		}

		public LiftControllerStatus GetStatus()
		{
			_log.Info("GetStatus()");

			return new LiftControllerStatus
			{
				LiftStatuses = _shafts.Select(s => s.Lift.GetStatusReport())
			};
		}
	}
}
