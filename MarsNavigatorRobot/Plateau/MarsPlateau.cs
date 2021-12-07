using System;

namespace MarsNavigatorRobot.Plateau
{
    public class MarsPlateau : IPlateau
    {
        private int _xGrid;
        private int _yGrid;

        public MarsPlateau(string grid)
        {
            _xGrid = Convert.ToInt32(grid.ToUpper().Split('X')[0]);
            _yGrid = Convert.ToInt32(grid.ToUpper().Split('X')[1]);
        }        

        public int GetXGrid()
        {
            return _xGrid;
        }

        public int GetYGrid()
        {
            return _yGrid;
        }
    }
}
