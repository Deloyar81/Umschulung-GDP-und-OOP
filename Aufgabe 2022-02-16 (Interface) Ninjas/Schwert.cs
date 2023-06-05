using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Ninjas
{
    internal class Schwert : IWaffe
    {
        public void GegnerTreffen(string gegner)
        {
            Console.WriteLine("Das {0} zetrennte {1} genau in der Mitte.", GetType().Name, gegner);
        }


    }
}
