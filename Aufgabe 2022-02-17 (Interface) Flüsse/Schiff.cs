using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_16__Interface__Flüsse
{
    internal class Schiff : IBeobachter
    {
        private string name;

        public Schiff(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }
        public void WasserpegelÄnderung(double wasserstand)
        {
            if (wasserstand >= 9)
            {
                Console.WriteLine();
                Console.WriteLine("{0} {1}: Der Fluss führt nicht die optimale Menge an Wasser, Schiffe dürfen nicht passieren.", GetType().Name, name);
            }
        }
    }
}
