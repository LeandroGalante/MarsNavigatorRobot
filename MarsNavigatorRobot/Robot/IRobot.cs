using MarsNavigatorRobot.Compass;
using MarsNavigatorRobot.Plateau;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsNavigatorRobot.Robot
{
    public interface IRobot
    {
        void Navigate();
        string GetCurrentPosition();
    }
}
