using MarsNavigatorRobot.Compass;
using MarsNavigatorRobot.Plateau;
using MarsNavigatorRobot.Position;
using MarsNavigatorRobot.Robot;
using System;

namespace MarsNavigatorRobot.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input1: Mars plateau is a grid such as 5x5, 3x4, etc.");
            Console.WriteLine("Input2: The Command to move the Robot. Sample command string: LFLRFLFF");

            Console.WriteLine("\nEnter Input1:");
            var grid = Console.ReadLine();

            Console.WriteLine("\nEnter Input2:");
            var command = Console.ReadLine();

            var currentPosition = new CurrentPosition();
            var marsPlateu = new MarsPlateau(grid);
            var compassNavigator = new CompassNavigator();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, compassNavigator);
            var robot = new MarsRobot(command, currentPosition, positionNavigator);

            //Act
            robot.Navigate();
            Console.WriteLine($"\nResult: {robot.GetCurrentPosition()}");

            Console.ReadKey();

        }
    }
}
