using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_21__Events__Wasserbüffel
{
    internal class Wasserbüffel : IBeobachter
    {
        public void WasserpegelÄnderung(double wasserstand)
        {
            if (wasserstand <= 0.3)
            {
                Console.WriteLine();
                Console.WriteLine("{0}-Hirte: Der Wasserstand ist zu niedrig, es wird zu trocken für die Wasserbüffel. Zusätzliches Tränken ist erforderlich", GetType().Name);
            }
            else if (wasserstand >=5 && wasserstand <= 7)
            {
                Console.WriteLine();
                Console.WriteLine("{0}-Hirte: Der Wasserstand ist zu hoch, die Wiesen werden überschwemmt und die Büffel müssen in den Stall", GetType().Name);

            }
            else if (wasserstand >7)
            {
                Console.WriteLine();
                Console.WriteLine("{0}-Hirte: Hochwasser! Die Büffel müssen sofort evakuiert werden", GetType().Name);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("{0}-Hirte: Perfekter Wasserstand für Wasserbüffel.", GetType().Name);
            }
        }
    }
}
