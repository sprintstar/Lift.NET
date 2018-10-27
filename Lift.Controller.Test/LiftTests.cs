using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lift.Controller.Test
{
    [TestClass]
    public class LiftTests
    {
        [TestMethod]
        public void NewliftState()
        {
            var lift = new Domain.Lift();

            Assert.AreEqual(lift.DestinationfloorLevel, 0);
            Assert.AreEqual(lift.Status, Enums.LiftStatus.Stationary);
        }
    }
}
