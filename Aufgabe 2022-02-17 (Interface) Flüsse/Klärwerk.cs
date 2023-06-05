using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Flüsse
{
    internal class Klärwerk : IBeobachter
    {
        private string name;

        public Klärwerk(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }
        public void WasserpegelÄnderung(double wasserstand)
        {
            if (wasserstand < 3000)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1}: Der Wasserstand des Flusses ist zu niedrig, die Einleitung muss erhöht werden", GetType().Name, name);
            }
            else if (wasserstand > 8000)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1}: Der Wasserstand des Flusses ist zu hoch, die Einleitung muss gestoppt werden", GetType().Name, name);

            }
        }
    }
}
