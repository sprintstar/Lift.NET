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

        public LiftController(ITinyMessengerHub tinyMessengerHub, Config config)
        {
            _log.Info("LiftController created");

            _shafts = config.Shafts.Select(s => new Shaft(s.Floors.Select(f => new Floor(f.Level)).ToList() as IList<IFloor>, new Lift($"{s.Name} lift")));

            _tinyMessengerHub = tinyMessengerHub;
            _tinyMessengerHub.Subscribe<ButtonPressMessage>((m) => { _log.Info($"Button press received from floor {m.Floor}, shaft {m.Shaft}"); });
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
