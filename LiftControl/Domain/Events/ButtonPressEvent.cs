using LiftControl.Enums;

namespace LiftControl.Domain.Events
{
	public class ButtonPressEvent : IButtonPressEvent
	{
		public ButtonPressEvent(ButtonPressEventSourceEnum buttonPressEventSource)
		{
			ButtonPressEventSource = buttonPressEventSource;
		}

		public ButtonPressEventSourceEnum ButtonPressEventSource { get; }
	}
}
