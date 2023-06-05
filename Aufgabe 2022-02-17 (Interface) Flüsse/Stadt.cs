using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Flüsse
{
    internal class Stadt : IBeobachter
    {
        private string name;

        public Stadt(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }

        public void WasserpegelÄnderung(double wasserstand)
        {
            if(wasserstand < 8200)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1}: Der Wasserstand ist zu hoch, es müssen Wasserschutzwände errichtet werden.", GetType().Name, name);
            }
        }
    }
}

