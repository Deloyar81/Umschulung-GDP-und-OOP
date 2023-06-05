using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_18__Events__Warpkern
{
    internal class WarpkernKonsole
    {
        private Warpkern warpkern;
        public WarpkernKonsole(Warpkern warpkern)
        {
            this.warpkern = warpkern;
        }

        public void GeänderteTemperatur(int alt, int neu)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nVorherige Warpkern-Temperatur: {0}" +
                                "\nAktuelle Warpkern-Temperatur: {1}", alt, neu);
            Console.ResetColor();
        }
        public void  WarpkernWarnung(int alt, int neu)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n!!! Warnung !!!   Warnung !!! Warnung!!!");
            Console.WriteLine();
            Console.WriteLine("Vorherige Warpkern-Temperatur: {0}" +
                                "\nWARNUNG: Temperatur liegt bei {1}",alt, neu);
            Console.WriteLine();
            Console.WriteLine("!!! Warnung !!!   Warnung !!! Warnung!!!");
            Console.ResetColor();
        }
    }
}
