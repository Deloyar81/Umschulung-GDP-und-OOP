using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Wasserbüffel
{
    internal class Wanderweg : IBeobachter
    {
        public void WasserpegelÄnderung(double wasserstand)
        {
            if(wasserstand <= 1)
            {
                Console.WriteLine();
                Console.WriteLine("{0}: Der Wasserstand ist niedrig genug zum durchqeren des Flusses.", GetType().Name);
            }
            else if(wasserstand >= 6)
            {
                Console.WriteLine();
                Console.WriteLine("{0}: Der Wanderweg ist überschwemmt!", GetType().Name);
            }
        }
    }
}

