using MarsNavigatorRobot.Position;

namespace MarsNavigatorRobot.Robot
{
    public class MarsRobot : IRobot
    {
        private ICurrentPosition _currentPosition;
        private IPositionNavigator _positionNavigator;
        private string _navigationCommand;

        public MarsRobot(string navigationCommand, ICurrentPosition currentPosition, IPositionNavigator positionNavigator)
        {
            _navigationCommand = navigationCommand;
            _currentPosition = currentPosition;
            _positionNavigator = positionNavigator;
        }

        public string GetCurrentPosition()
        {
            return $"{_currentPosition.GetCurrentPosition().X},{_currentPosition.GetCurrentPosition().Y},{_currentPosition.GetCurrentSide()}";
        }

        public void Navigate()
        {
            foreach (var command in _navigationCommand)
            {
                _positionNavigator.Navigate(command);
            }
        }
    }
}
