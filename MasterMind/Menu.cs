using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterMind
{
    public class Menu
    {
       

        public Menu()
        {
            
        }

        

        public int PinEingabe()
        {
            Console.WriteLine("Welche Farbe soll der nächste Pin haben?");
            
            Console.WriteLine("(1) - Rot");
            Console.WriteLine("(2) - Gelb");
            Console.WriteLine("(3) - Blau");
            Console.WriteLine("(4) - Grün");

            return int.Parse(());
        }
    }
}