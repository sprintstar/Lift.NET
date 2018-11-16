using LiftControl.Domain;
using LiftControl.Model.Messages.In;
using LiftControl.Model.Statuses;
using log4net;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TinyMessenger;

namespace LiftControl
{
    public class LiftController
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly IEnumerable<IShaft> _shafts;
        private readonly ITinyMessengerHub _tinyMessengerHub;

        public LiftController(ITinyMessengerHub tinyMessengerHub)
        {
            _log.Info("LiftController created");

            // Create lifts, floors and shafts
            var floors = Enumerable.Range(1, 10).Select(f => new Floor(f) as IFloor).ToList();
            _shafts = new List<IShaft>
            {
                new Shaft(floors, new Lift("Lift 1"))
            };

            _tinyMessengerHub = tinyMessengerHub;
            _tinyMessengerHub.Subscribe<ButtonPressMessage>((m) => { _log.Info($"Button press received from floor {m.Floor}"); });
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
