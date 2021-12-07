using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsNavigatorRobot.Compass
{
    public interface ICompassNavigator
    {
        CompassPointEnum Navigate(char command);
    }
}
