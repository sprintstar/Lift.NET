using LiftControl.Enums;

namespace LiftControl.Domain.Events
{
	public interface IButtonPressEvent : IEvent
	{
		ButtonPressEventSourceEnum ButtonPressEventSource { get; }
	}
}
