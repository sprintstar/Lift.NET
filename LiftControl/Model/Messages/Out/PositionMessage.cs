using LiftControl.Enums;
using TinyMessenger;

namespace LiftControl.Model.Messages.Out
{
    public class PositionMessage : ITinyMessage
    {
        public object Sender { get; private set; }
        public LiftStatusEnum  Status { get; set; }
        public int TargetFloor { get; set; }
        public LiftDirectionEnum Direction { get; set; }
    }
}
