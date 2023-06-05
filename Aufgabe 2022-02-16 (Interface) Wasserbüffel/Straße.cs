using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Wasserbüffel
{
    internal class Straße : IBeobachter
    {
        public void WasserpegelÄnderung(double wasserstand)
        {
            if (wasserstand >= 9)
            {
                Console.WriteLine();
                Console.WriteLine("{0}nwacht: Die Dammstraße ist überschwemmt, eine Sperrung wurde veranlaßt.", GetType().Name);
            }
        }
    }
}
