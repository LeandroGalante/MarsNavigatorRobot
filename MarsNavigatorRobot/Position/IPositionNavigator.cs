namespace MarsNavigatorRobot.Position
{
    public interface IPositionNavigator
    {
        void Navigate(char command);
        ICurrentPosition GetCurrentPosition();
    }
}
