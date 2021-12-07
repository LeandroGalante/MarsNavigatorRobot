using NUnit.Framework;
using MarsNavigatorRobot.Robot;
using MarsNavigatorRobot.Plateau;
using MarsNavigatorRobot.Compass;
using Moq;
using MarsNavigatorRobot.Position;

namespace MarsNavigatorRobot.Test
{
    [TestFixture]
    class RobotTests
    {
        [Test]
        public void RobotNavigateOnMarsSuccess()
        {
            //Arrange            
            var currentPosition = new CurrentPosition();
            var marsPlateu = new MarsPlateau("5x5");
            var compassNavigator = new CompassNavigator();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, compassNavigator);
            var robot = new MarsRobot("FFRFLFLF", currentPosition, positionNavigator);            

            //Act
            robot.Navigate();
            var result = robot.GetCurrentPosition();

            //Assert
            Assert.AreEqual("1,4,West", result);
        }

        [Test]
        public void RobotNavigateOnMarsFailure()
        {
            //Arrange            
            var currentPosition = new CurrentPosition();
            var marsPlateu = new MarsPlateau("5x5");
            var compassNavigator = new CompassNavigator();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, compassNavigator);
            var robot = new MarsRobot("FFF", currentPosition, positionNavigator);

            //Act
            robot.Navigate();
            var result = robot.GetCurrentPosition();

            //Assert
            Assert.AreNotEqual("1,4,West", result);
        }

        [Test]
        public void RobotAlwaysStartAtX1Y1FacingNorthSuccess()
        {
            //Arrange            
            var currentPosition = new CurrentPosition();
            var marsPlateu = new MarsPlateau("5x5");
            var compassNavigator = new CompassNavigator();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, compassNavigator);
            var robot = new MarsRobot("FFFFFFFF", currentPosition, positionNavigator);

            //Act            
            var result = robot.GetCurrentPosition();

            //Assert
            Assert.AreEqual("1,1,North", result);
        }

        [Test]
        public void IfRobotReachesLimitsCommandBeIgnoredSuccess()
        {
            //Arrange            
            var currentPosition = new CurrentPosition();
            var marsPlateu = new MarsPlateau("5x5");
            var compassNavigator = new CompassNavigator();
            var positionNavigator = new PositionNavigator(currentPosition, marsPlateu, compassNavigator);
            var robot = new MarsRobot("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", currentPosition, positionNavigator);

            //Act       
            robot.Navigate();
            var result = robot.GetCurrentPosition();

            //Assert
            Assert.AreEqual("1,5,North", result);
        }


    }
}
