using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_17__Interface__Movable
{
    internal class MovablePoint : IMovable
    {
        protected double x;
        protected double y;
        protected double xspeed = 3;
        protected double yspeed = 2;

        public MovablePoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Xspeed { get; set; }
        public double Yspeed { get; set; }


        public void MoveLeft()
        {
            x -= xspeed;
        }

        public void MoveRight()
        {
            x += xspeed;
        }

        public void MoveUp()
        {
            y -= yspeed;
        }

        public void MoveDown()
        {
            y += yspeed;
        }

        public override string ToString()
        {
            return string.Format("Position X = {0}, Position Y = {1}", x, y);
        }
    }
}
