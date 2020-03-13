using System.Drawing;

namespace Methods
{
    public class Points
    {
        public int X;
        public int Y;

        public Points(int x,int y)
        {
            this.X = y;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = y;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.X = newLocation.Y;
        }
    }
}