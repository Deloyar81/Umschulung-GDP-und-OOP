using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Bite : Schlange
    {
        private int positionx;
        private int postitiony;
        private bool existence = true;
        private int posleft, poright, postop, posbottom;

        public Bite(int startx, int starty, int positionx, int positiony, bool existence) : base(startx, starty)
        {
            Random random = new Random();
            Console.SetCursorPosition(random.Next(), random.Next(10, starty));
            Console.Write(1);
            score =+ 10;
        }

        public Bite(int startx, int starty, int posleft, int posright, int postop, int posbottom) : base(startx, starty)
        {
            Random random = new Random();
            Console.SetCursorPosition(random.Next(posleft, posright), random.Next(postop, posbottom));
            Console.Write(1);
        }

        public int Snakespeed(int speed, bool bite)
        {
            if(bite == true)
            {
                return speed + 100;
            }
            else
            {
                return speed;
            }
            
        }




    }
}
