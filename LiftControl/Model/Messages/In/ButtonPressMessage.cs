using TinyMessenger;

namespace LiftControl.Model.Messages.In
{
    public class ButtonPressMessage : ITinyMessage
    {
        public object Sender { get; private set; }
        public string Shaft { get; }
        public int Floor { get; }

        public ButtonPressMessage(string shaft, int floor)
        {
            Shaft = shaft;
            Floor = floor;
        }
    }
}
