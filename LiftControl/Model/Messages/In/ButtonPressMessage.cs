using TinyMessenger;

namespace LiftControl.Model.Messages.In
{
    public class ButtonPressMessage : ITinyMessage
    {
        public object Sender { get; private set; }
        public int Floor { get; }

        public ButtonPressMessage(int floor)
        {
            Floor = floor;
        }
    }
}
