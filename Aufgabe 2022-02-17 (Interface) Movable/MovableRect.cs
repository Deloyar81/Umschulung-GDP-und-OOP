using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_17__Interface__Movable
{
     internal class MovableRect : IMovable
    {
        private MovablePoint upperLeftCorner;
        private MovablePoint lowerRightCorner;
        private double xspeed = 3;
        private double yspeed = 2;

        public MovableRect(MovablePoint p1, MovablePoint p2)
        {
            upperLeftCorner = p1;
            lowerRightCorner = p2;
        }

        public MovablePoint UpperLeftCorner { get { return upperLeftCorner; } set { upperLeftCorner = value; } }

        public MovablePoint LowerRightCorner { get { return lowerRightCorner; } set { lowerRightCorner = value; } }

        public double Xspeed { get { return xspeed; } set { xspeed = value; upperLeftCorner.Xspeed = value; lowerRightCorner.Xspeed = value; } }

        public double Yspeed { get { return yspeed; } set { yspeed = value; upperLeftCorner.Yspeed = value; lowerRightCorner.Yspeed = value; } }

        public void MoveDown()
        {
            upperLeftCorner.MoveDown();
            lowerRightCorner.MoveDown();
        }

        public void MoveLeft()
        {
            upperLeftCorner.MoveLeft();
            lowerRightCorner.MoveLeft();
        }

        public void MoveRight()
        {
            upperLeftCorner.MoveRight();
            lowerRightCorner.MoveRight();
        }

        public void MoveUp()
        {
            upperLeftCorner.MoveUp();
            lowerRightCorner.MoveUp();
        }

        public override string ToString()
        {
            return String.Format("Das Rechteck ist zwischen {0} und {1}", upperLeftCorner, lowerRightCorner);
        }
    }
}
