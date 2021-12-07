using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsNavigatorRobot.Position
{
    public interface ICurrentPosition
    {
        void SetCurrentPosition(PositionDto position);
        void SetCurrentSide(CompassPointEnum compassPointEnum);
        PositionDto GetCurrentPosition();
        CompassPointEnum GetCurrentSide();
        void AddX(int number);
        void AddY(int number);

    }
}
