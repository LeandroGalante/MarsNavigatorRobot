using MarsNavigatorRobot.Compass;
using MarsNavigatorRobot.Plateau;
using MarsNavigatorRobot.Position;
using MarsNavigatorRobot.Robot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsNavigatorRobot.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.

            var currentPosition = new CurrentPosition();
            var marsPlateu = new MarsPlateau("5x5");
            var compassNavigator = new CompassNavigator();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, compassNavigator);
            var robot = new MarsRobot("FFRFLFLF", currentPosition, positionNavigator);

            
        }
    }
}
