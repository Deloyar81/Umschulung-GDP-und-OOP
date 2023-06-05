using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Ninjas
{
    internal class Shuriken : IWaffe
    {
        public void GegnerTreffen(string gegner)
        {
            Console.WriteLine("Der {0} traf {1} mit voller Wucht.", GetType().Name, gegner);
        }
    }
}
