using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Schlange
    {
        //Variablen
        protected int speed = 100;
        protected int x;
        protected int y;
        protected int score = 0;
        protected int lives = 5;

        public Schlange(int startx, int starty)
        {
            //random Startposition
            Random random = new Random();
            x = random.Next(10, startx);
            y = random.Next(10, starty);
        }

        //Startposition der Snake initialisieren mit randomfaktor
        public void Startposition(int posx, int posy)
        {
            Console.SetCursorPosition(posx + x, posy + y);
            Console.Write("0");
        }

        //Bewegung der Snake
        public void Move()
        {


            //while(true)
            //{
            //    if (Console.GetCursorPosition(spielfeldleft, ))
            //    {

            //    }
            //}
        }

        //Score- und Leben-Darstellung
        public void Score()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 4, 5);
            Console.WriteLine("Lives: {0, 1}", lives);
            Console.SetCursorPosition(Console.WindowWidth / 2 - 6, 7);
            Console.WriteLine("Score: {0, 5}", score);
        }

        //Tod der Snake
        public void DieHard()
        {
            
        }


    }
}
