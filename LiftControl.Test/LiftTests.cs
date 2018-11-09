using LiftControl.Domain;
using LiftControl.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiftControl.Test
{
	[TestClass]
	public class LiftTests
	{
		[TestMethod]
		public void NewliftState()
		{
			var lift = new Lift("Test lift 1");

			Assert.AreEqual(lift.DestinationfloorLevel, 0);
			Assert.AreEqual(lift.Status, LiftStatusEnum.Stationary);
		}
	}
}
