namespace MarsNavigatorRobot.Position
{
    public class CurrentPosition: ICurrentPosition
    {
        private PositionDto _currentPosition;
        private CompassPointEnum _currentSide;

        public CurrentPosition()
        {
            _currentPosition = new PositionDto(1,1);
            _currentSide = CompassPointEnum.North;
        }

        public void AddX(int number)
        {
            _currentPosition.X += number;
        }

        public void AddY(int number)
        {
            _currentPosition.Y += number;
        }

        public PositionDto GetCurrentPosition()
        {
            return _currentPosition;
        }

        public CompassPointEnum GetCurrentSide()
        {
            return _currentSide;
        }       

        public void SetCurrentPosition(PositionDto position)
        {
            _currentPosition = position;
        }

        public void SetCurrentSide(CompassPointEnum compassPointEnum)
        {
            _currentSide = compassPointEnum;
        }      
    }
}
