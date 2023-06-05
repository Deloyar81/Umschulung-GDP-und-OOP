using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_09__Delegates__Array_MinMax
{
    delegate bool VergleichsDelegate(int x, int y);
    class Vergleich
    {
        public bool IstKleiner(int a, int b)
        { return a < b; }

        public bool IstGroesser(int a, int b)
        { return a > b; }

    }
}
