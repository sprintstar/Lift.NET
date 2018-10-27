using Lift.Controller.Domain;
using Lift.Controller.Interfaces;
using System.Linq;

namespace Lift.Controller
{
    public class Controller
    {
        public Controller()
        {
            var floors = Enumerable.Range(1, 10).Select(f => new Floor(f) as IFloor).ToList();
            var lift = new Domain.Lift();
            var shaft = new Shaft(floors, lift);
        }
    }
}
